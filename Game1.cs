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
        internal static RenderTarget2D _renderTarget;
        internal static Rectangle _renderDestination;
        internal static MouseState mouseState;
        public static class Pressed
        {
            // 알파벳
            public static bool a;
            public static bool b;
            public static bool c;
            public static bool d;
            public static bool e;
            public static bool f;
            public static bool g;
            public static bool h;
            public static bool i;
            public static bool j;
            public static bool k;
            public static bool l;
            public static bool m;
            public static bool n;
            public static bool o;
            public static bool p;
            public static bool q;
            public static bool r;
            public static bool s;
            public static bool t;
            public static bool u;
            public static bool v;
            public static bool w;
            public static bool x;
            public static bool y;
            public static bool z;
            // 숫자
            public static bool zero;
            public static bool one;
            public static bool two;
            public static bool three;
            public static bool four;
            public static bool five;
            public static bool six;
            public static bool seven;
            public static bool eight;
            public static bool nine;
            // 화살표(방향키)
            public static bool leftArrow;
            public static bool rightArrow;
            public static bool upArrow;
            public static bool downArrow;
            // 시스템
            // F
            public static bool esc;
            public static bool f1;
            public static bool f2;
            public static bool f3;
            public static bool f4;
            public static bool f5;
            public static bool f6;
            public static bool f7;
            public static bool f8;
            public static bool f9;
            public static bool f10;
            public static bool f11;
            public static bool f12;
            // 특수문자?
            public static bool tab;
            public static bool minus;
            public static bool equal;
            public static bool enter;
            public static bool leftShift;
            public static bool rightShift;
        }
        public static class Holded
        {
            // 알파벳
            public static bool a;
            public static bool b;
            public static bool c;
            public static bool d;
            public static bool e;
            public static bool f;
            public static bool g;
            public static bool h;
            public static bool i;
            public static bool j;
            public static bool k;
            public static bool l;
            public static bool m;
            public static bool n;
            public static bool o;
            public static bool p;
            public static bool q;
            public static bool r;
            public static bool s;
            public static bool t;
            public static bool u;
            public static bool v;
            public static bool w;
            public static bool x;
            public static bool y;
            public static bool z;
            // 숫자
            public static bool zero;
            public static bool one;
            public static bool two;
            public static bool three;
            public static bool four;
            public static bool five;
            public static bool six;
            public static bool seven;
            public static bool eight;
            public static bool nine;
            // 화살표(방향키)
            public static bool leftArrow;
            public static bool rightArrow;
            public static bool upArrow;
            public static bool downArrow;
            // 시스템
            // F
            public static bool esc;
            public static bool f1;
            public static bool f2;
            public static bool f3;
            public static bool f4;
            public static bool f5;
            public static bool f6;
            public static bool f7;
            public static bool f8;
            public static bool f9;
            public static bool f10;
            public static bool f11;
            public static bool f12;
            // 특수문자?
            public static bool tab;
            public static bool minus;
            public static bool equal;
            public static bool enter;
            public static bool leftShift;
            public static bool rightShift;
        }

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

        private static void KeyResets()
        {
            var ks = Keyboard.GetState();
            // 한번입력
            Pressed.a = ks.IsKeyDown(Keys.A) && !oldKeyboardState.IsKeyDown(Keys.A);
            Pressed.b = ks.IsKeyDown(Keys.B) && !oldKeyboardState.IsKeyDown(Keys.B);
            Pressed.c = ks.IsKeyDown(Keys.C) && !oldKeyboardState.IsKeyDown(Keys.C);
            Pressed.d = ks.IsKeyDown(Keys.D) && !oldKeyboardState.IsKeyDown(Keys.D);
            Pressed.e = ks.IsKeyDown(Keys.E) && !oldKeyboardState.IsKeyDown(Keys.E);
            Pressed.f = ks.IsKeyDown(Keys.F) && !oldKeyboardState.IsKeyDown(Keys.F);
            Pressed.g = ks.IsKeyDown(Keys.G) && !oldKeyboardState.IsKeyDown(Keys.G);
            Pressed.h = ks.IsKeyDown(Keys.H) && !oldKeyboardState.IsKeyDown(Keys.H);
            Pressed.i = ks.IsKeyDown(Keys.I) && !oldKeyboardState.IsKeyDown(Keys.I);
            Pressed.j = ks.IsKeyDown(Keys.J) && !oldKeyboardState.IsKeyDown(Keys.J);
            Pressed.k = ks.IsKeyDown(Keys.K) && !oldKeyboardState.IsKeyDown(Keys.K);
            Pressed.l = ks.IsKeyDown(Keys.L) && !oldKeyboardState.IsKeyDown(Keys.L);
            Pressed.m = ks.IsKeyDown(Keys.M) && !oldKeyboardState.IsKeyDown(Keys.M);
            Pressed.n = ks.IsKeyDown(Keys.N) && !oldKeyboardState.IsKeyDown(Keys.N);
            Pressed.o = ks.IsKeyDown(Keys.O) && !oldKeyboardState.IsKeyDown(Keys.O);
            Pressed.p = ks.IsKeyDown(Keys.P) && !oldKeyboardState.IsKeyDown(Keys.P);
            Pressed.q = ks.IsKeyDown(Keys.Q) && !oldKeyboardState.IsKeyDown(Keys.Q);
            Pressed.r = ks.IsKeyDown(Keys.R) && !oldKeyboardState.IsKeyDown(Keys.R);
            Pressed.s = ks.IsKeyDown(Keys.S) && !oldKeyboardState.IsKeyDown(Keys.S);
            Pressed.t = ks.IsKeyDown(Keys.T) && !oldKeyboardState.IsKeyDown(Keys.T);
            Pressed.u = ks.IsKeyDown(Keys.U) && !oldKeyboardState.IsKeyDown(Keys.U);
            Pressed.v = ks.IsKeyDown(Keys.V) && !oldKeyboardState.IsKeyDown(Keys.V);
            Pressed.w = ks.IsKeyDown(Keys.W) && !oldKeyboardState.IsKeyDown(Keys.W);
            Pressed.x = ks.IsKeyDown(Keys.X) && !oldKeyboardState.IsKeyDown(Keys.X);
            Pressed.y = ks.IsKeyDown(Keys.Y) && !oldKeyboardState.IsKeyDown(Keys.Y);
            Pressed.z = ks.IsKeyDown(Keys.Z) && !oldKeyboardState.IsKeyDown(Keys.Z);

            Pressed.zero = ks.IsKeyDown(Keys.D0) && !oldKeyboardState.IsKeyDown(Keys.D0);
            Pressed.one = ks.IsKeyDown(Keys.D1) && !oldKeyboardState.IsKeyDown(Keys.D1);
            Pressed.two = ks.IsKeyDown(Keys.D2) && !oldKeyboardState.IsKeyDown(Keys.D2);
            Pressed.three = ks.IsKeyDown(Keys.D3) && !oldKeyboardState.IsKeyDown(Keys.D3);
            Pressed.four = ks.IsKeyDown(Keys.D4) && !oldKeyboardState.IsKeyDown(Keys.D4);
            Pressed.five = ks.IsKeyDown(Keys.D5) && !oldKeyboardState.IsKeyDown(Keys.D5);
            Pressed.six = ks.IsKeyDown(Keys.D6) && !oldKeyboardState.IsKeyDown(Keys.D6);
            Pressed.seven = ks.IsKeyDown(Keys.D7) && !oldKeyboardState.IsKeyDown(Keys.D7);
            Pressed.eight = ks.IsKeyDown(Keys.D8) && !oldKeyboardState.IsKeyDown(Keys.D8);
            Pressed.nine = ks.IsKeyDown(Keys.D9) && !oldKeyboardState.IsKeyDown(Keys.D9);

            Pressed.leftArrow = ks.IsKeyDown(Keys.Left) && !oldKeyboardState.IsKeyDown(Keys.Left);
            Pressed.rightArrow = ks.IsKeyDown(Keys.Right) && !oldKeyboardState.IsKeyDown(Keys.Right);
            Pressed.upArrow = ks.IsKeyDown(Keys.Up) && !oldKeyboardState.IsKeyDown(Keys.Up);
            Pressed.downArrow = ks.IsKeyDown(Keys.Down) && !oldKeyboardState.IsKeyDown(Keys.Down);

            Pressed.esc = ks.IsKeyDown(Keys.Escape) && !oldKeyboardState.IsKeyDown(Keys.Escape);
            Pressed.f1 = ks.IsKeyDown(Keys.F1) && !oldKeyboardState.IsKeyDown(Keys.F1);
            Pressed.f2 = ks.IsKeyDown(Keys.F2) && !oldKeyboardState.IsKeyDown(Keys.F2);
            Pressed.f3 = ks.IsKeyDown(Keys.F3) && !oldKeyboardState.IsKeyDown(Keys.F3);
            Pressed.f4 = ks.IsKeyDown(Keys.F4) && !oldKeyboardState.IsKeyDown(Keys.F4);
            Pressed.f5 = ks.IsKeyDown(Keys.F5) && !oldKeyboardState.IsKeyDown(Keys.F5);
            Pressed.f6 = ks.IsKeyDown(Keys.F6) && !oldKeyboardState.IsKeyDown(Keys.F6);
            Pressed.f7 = ks.IsKeyDown(Keys.F7) && !oldKeyboardState.IsKeyDown(Keys.F7);
            Pressed.f8 = ks.IsKeyDown(Keys.F8) && !oldKeyboardState.IsKeyDown(Keys.F8);
            Pressed.f9 = ks.IsKeyDown(Keys.F9) && !oldKeyboardState.IsKeyDown(Keys.F9);
            Pressed.f10 = ks.IsKeyDown(Keys.F10) && !oldKeyboardState.IsKeyDown(Keys.F10);
            Pressed.f11 = ks.IsKeyDown(Keys.F11) && !oldKeyboardState.IsKeyDown(Keys.F11);
            Pressed.f12 = ks.IsKeyDown(Keys.F12) && !oldKeyboardState.IsKeyDown(Keys.F12);

            Pressed.tab = ks.IsKeyDown(Keys.Tab) && !oldKeyboardState.IsKeyDown(Keys.Tab);
            Pressed.minus = ks.IsKeyDown(Keys.OemMinus) && !oldKeyboardState.IsKeyDown(Keys.OemMinus);
            Pressed.equal = ks.IsKeyDown(Keys.OemPlus) && !oldKeyboardState.IsKeyDown(Keys.OemPlus);
            Pressed.enter = ks.IsKeyDown(Keys.Enter) && !oldKeyboardState.IsKeyDown(Keys.Enter);
            Pressed.leftShift = ks.IsKeyDown(Keys.LeftShift) && !oldKeyboardState.IsKeyDown(Keys.LeftShift);
            Pressed.rightShift = ks.IsKeyDown(Keys.RightShift) && !oldKeyboardState.IsKeyDown(Keys.RightShift);
            // 계속입력
            Holded.a = ks.IsKeyDown(Keys.A);
            Holded.b = ks.IsKeyDown(Keys.B);
            Holded.c = ks.IsKeyDown(Keys.C);
            Holded.d = ks.IsKeyDown(Keys.D);
            Holded.e = ks.IsKeyDown(Keys.E);
            Holded.f = ks.IsKeyDown(Keys.F);
            Holded.g = ks.IsKeyDown(Keys.G);
            Holded.h = ks.IsKeyDown(Keys.H);
            Holded.i = ks.IsKeyDown(Keys.I);
            Holded.j = ks.IsKeyDown(Keys.J);
            Holded.k = ks.IsKeyDown(Keys.K);
            Holded.l = ks.IsKeyDown(Keys.L);
            Holded.m = ks.IsKeyDown(Keys.M);
            Holded.n = ks.IsKeyDown(Keys.N);
            Holded.o = ks.IsKeyDown(Keys.O);
            Holded.p = ks.IsKeyDown(Keys.P);
            Holded.q = ks.IsKeyDown(Keys.Q);
            Holded.r = ks.IsKeyDown(Keys.R);
            Holded.s = ks.IsKeyDown(Keys.S);
            Holded.t = ks.IsKeyDown(Keys.T);
            Holded.u = ks.IsKeyDown(Keys.U);
            Holded.v = ks.IsKeyDown(Keys.V);
            Holded.w = ks.IsKeyDown(Keys.W);
            Holded.x = ks.IsKeyDown(Keys.X);
            Holded.y = ks.IsKeyDown(Keys.Y);
            Holded.z = ks.IsKeyDown(Keys.Z);

            Holded.zero = ks.IsKeyDown(Keys.D0);
            Holded.one = ks.IsKeyDown(Keys.D1);
            Holded.two = ks.IsKeyDown(Keys.D2);
            Holded.three = ks.IsKeyDown(Keys.D3);
            Holded.four = ks.IsKeyDown(Keys.D4);
            Holded.five = ks.IsKeyDown(Keys.D5);
            Holded.six = ks.IsKeyDown(Keys.D6);
            Holded.seven = ks.IsKeyDown(Keys.D7);
            Holded.eight = ks.IsKeyDown(Keys.D8);
            Holded.nine = ks.IsKeyDown(Keys.D9);

            Holded.leftArrow = ks.IsKeyDown(Keys.Left);
            Holded.rightArrow = ks.IsKeyDown(Keys.Right);
            Holded.upArrow = ks.IsKeyDown(Keys.Up);
            Holded.downArrow = ks.IsKeyDown(Keys.Down);

            Holded.esc = ks.IsKeyDown(Keys.Escape);
            Holded.f1 = ks.IsKeyDown(Keys.F1);
            Holded.f2 = ks.IsKeyDown(Keys.F2);
            Holded.f3 = ks.IsKeyDown(Keys.F3);
            Holded.f4 = ks.IsKeyDown(Keys.F4);
            Holded.f5 = ks.IsKeyDown(Keys.F5);
            Holded.f6 = ks.IsKeyDown(Keys.F6);
            Holded.f7 = ks.IsKeyDown(Keys.F7);
            Holded.f8 = ks.IsKeyDown(Keys.F8);
            Holded.f9 = ks.IsKeyDown(Keys.F9);
            Holded.f10 = ks.IsKeyDown(Keys.F10);
            Holded.f11 = ks.IsKeyDown(Keys.F11);
            Holded.f12 = ks.IsKeyDown(Keys.F12);

            Holded.tab = ks.IsKeyDown(Keys.Tab);
            Holded.minus = ks.IsKeyDown(Keys.OemMinus);
            Holded.equal = ks.IsKeyDown(Keys.OemPlus);
            Holded.enter = ks.IsKeyDown(Keys.Enter);
            Holded.leftShift = ks.IsKeyDown(Keys.LeftShift);
            Holded.rightShift = ks.IsKeyDown(Keys.RightShift);
            oldKeyboardState = ks;
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
        /// <summary>
        /// 테두리 없는 창모드
        /// </summary>
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

            KeyResets();
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
