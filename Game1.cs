using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended.BitmapFonts;

namespace BCCC
{
    public class Game1 : Game
    {
        internal static GraphicsDeviceManager _graphics;
        internal static Microsoft.Xna.Framework.Graphics.SpriteBatch _spriteBatch;
        internal static float deltaTime;
        internal static MouseState oldMouseState;
        internal static bool LeftMouse;
        internal static bool RightMouse;
        internal static KeyboardState oldKeyboardState;
        internal static bool escPressed;
        internal static RenderTarget2D _renderTarget;
        internal static Rectangle _renderDestination;
        internal static MouseState mouseState;

        public class Batch
        {
            public static void Start()
            {
                _spriteBatch.Begin();
            }
            public static void TextStart()
            {
                _spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.PointClamp);
            }
            public static void End()
            {
                _spriteBatch.End();
            }

            /// <summary>
            /// 이미지 그리기
            /// </summary>
            /// <param name="img">Texture2D</param>
            /// <param name="pos">Vector2</param>
            /// <param name="size">float</param>
            /// <param name="col">Color</param>
            /// <param name="angle">float</param>
            /// <param name="origin">Vector2</param>
            public static void Img(Texture2D img, Vector2 pos, float size = 0f, Color col = default, float angle = 0f, Vector2 origin = default) // 화면에 이미지 그리기
            {
                Vector2 size1;
                if (col == default) col = Color.White;
                if (size == 0f) size1 = Vector2.One; else size1 = new Vector2(size);
                if (origin == default) origin = Vector2.Zero;
                _spriteBatch.Draw(img, pos, null, col, angle, origin, size1, SpriteEffects.None, 0f);
            }
        
            /// <summary>
            /// 텍스트 그리기
            /// </summary>
            /// <param name="text">string</param>
            /// <param name="pos">Vector2</param>
            /// <param name="scale">float</param>
            /// <param name="color">Color</param>
            /// <param name="outline">bool</param>
            /// <param name="outlineColor">Color</param>
            /// <param name="thin">float</param>
            /// <param name="font">BitmapFont</param>
            /// <param name="angle">float</param>
            /// <param name="origin">Vector2</param>
            public static void Text(string text, Vector2 pos, float scale = 0f, Color color = default, bool outline = false, Color outlineColor = default, float thin = 2f, BitmapFont font = default, float angle = 0f, Vector2 origin = default) // 화면에 텍스트 그리기
            {
                Vector2 scale1;
                if (scale == 0f) scale1 = Vector2.One; else scale1 = new Vector2(scale);
                if (color == default) { color = Color.White; }
                if ((outlineColor == default) && outline) { outlineColor = Color.Black; }
                if (font == default) font = Fonts.MainFont;
                if (origin == default) origin = Vector2.Zero;
                if (outline == default) outline = false;
                if (outline)
                {
                    for (float x = -thin; x <= thin; x += thin)
                    {
                        for (float y = -thin; y <= thin; y += thin)
                        {
                            if (x == 0 && y == 0) continue;
                            _spriteBatch.DrawString(font, text, new Vector2(pos.X + x, pos.Y + y), outlineColor, angle, origin, scale1, SpriteEffects.None, 0f);
                        }
                    }
                }
                _spriteBatch.DrawString(font, text, pos, color, angle, origin, scale1, SpriteEffects.None, 0f);
            }
        }


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            Window.Title = Info.GameName;
            Window.IsBorderless = false;

            _graphics.PreferredBackBufferWidth = Info.width;
            _graphics.PreferredBackBufferHeight = Info.height;
            _graphics.ApplyChanges();

            Window.AllowUserResizing = true;
            Window.ClientSizeChanged += (s, e) => CalculateRenderDestination();
        }

        protected override void Initialize()
        {
            _renderTarget = new RenderTarget2D(GraphicsDevice, Info.width, Info.height);

            base.Initialize();
            CalculateRenderDestination();
        }

        private void CalculateRenderDestination()
        {
            float targetAspectRatio = (float)Info.width / Info.height;
            int width = Window.ClientBounds.Width;
            int height = Window.ClientBounds.Height;

            if (width <= 0 || height <= 0) return;
            float currentAspectRatio = (float)width / height;

            if (currentAspectRatio > targetAspectRatio)
            {
                int presentWidth = (int)(height * targetAspectRatio);
                int barWidth = (width - presentWidth) / 2;
                _renderDestination = new Rectangle(barWidth, 0, presentWidth, height);
            }
            else
            {
                int presentHeight = (int)(width / targetAspectRatio);
                int barHeight = (height - presentHeight) / 2;
                _renderDestination = new Rectangle(0, barHeight, width, presentHeight);
            }
        }

        protected override void LoadContent()
        {
            _spriteBatch = new Microsoft.Xna.Framework.Graphics.SpriteBatch(GraphicsDevice);

            Fonts.ReadFonts(GraphicsDevice);
            Texts.Init();
            Cards.Init();
        }

        protected override void Update(GameTime gameTime)
        {
            deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            MouseState raw = Mouse.GetState();
            mouseState = new MouseState(
                (int)((raw.X - _renderDestination.X) * ((float)Info.width / _renderDestination.Width)),
                (int)((raw.Y - _renderDestination.Y) * ((float)Info.height / _renderDestination.Height)),
                raw.ScrollWheelValue,
                raw.LeftButton,
                raw.MiddleButton,
                raw.RightButton,
                raw.XButton1,
                raw.XButton2
            ); // 지금 마우스 정보 구함
            States.MouseClickReset(mouseState); // 마우스 클릭 업ㄷ ㅔ이트
            // Q로 나가기
            if (Keyboard.GetState().IsKeyDown(Keys.Q) && !oldKeyboardState.IsKeyDown(Keys.Q))
                States.exit = true;
            // F4로 전체화면 전환
            if (Keyboard.GetState().IsKeyDown(Keys.F4) && !oldKeyboardState.IsKeyDown(Keys.F4))
            {
                Window.IsBorderless = !Window.IsBorderless;
                if (Window.IsBorderless)
                {
                    _graphics.PreferredBackBufferWidth = Info.mywidth;
                    _graphics.PreferredBackBufferHeight = Info.myheight;
                    _graphics.ApplyChanges();
                    Window.Position = Point.Zero;
                }
                else
                {
                    _graphics.PreferredBackBufferWidth = Info.width;
                    _graphics.PreferredBackBufferHeight = Info.height;
                    _graphics.ApplyChanges();
                    Window.Position = new Point((GraphicsDevice.Adapter.CurrentDisplayMode.Width - Info.width) / 2, (GraphicsDevice.Adapter.CurrentDisplayMode.Height - Info.height) / 2);
                }
                CalculateRenderDestination();
            }
            
            escPressed = Keyboard.GetState().IsKeyDown(Keys.Escape) && !oldKeyboardState.IsKeyDown(Keys.Escape);
            oldKeyboardState = Keyboard.GetState();
            Texts.Update();
            if (States.exit) Exit(); // 게임 종료
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.SetRenderTarget(_renderTarget);
            GraphicsDevice.Clear(Color.CornflowerBlue);

            SwitchCase.DrawDisplay();

            GraphicsDevice.SetRenderTarget(null);
            GraphicsDevice.Clear(Color.Black);

            _spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.PointClamp);
            _spriteBatch.Draw(_renderTarget, _renderDestination, Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
