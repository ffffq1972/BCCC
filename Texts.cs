using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonoGame.Extended;
using Microsoft.Xna.Framework.Input;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualBasic.ApplicationServices;
using MonoGame.Extended.Tilemaps;

namespace BCCC 
{
    public class makeVars
    {
        public string text;
        public Vector2 pos;
        public float scale;
        public bool outline;
        public float thin;
        public Color outlineColor;
        public float width;
        public float height;
        public Color color;
        public float rotation;
        public Vector2 origin;
        public SpriteEffects effects;
        public float angle;
        public bool isHovering;

        /// <summary>
        /// origin<br/>
        /// 첫번째 글자에 m, r, l로 Middle, Right, Left<br/>
        /// 두번째 글자에 m, b, t로 Middle, Bottom, Top
        /// </summary>
        public makeVars(string text, Vector2 pos, float scale, Color color, float rotation, SpriteEffects effects, string origin, bool outline, float thin, Color outlineColor, float angle)
        {
            this.text = text;
            this.pos = pos;
            this.scale = scale;
            this.outline = outline;
            this.thin = thin;
            this.outlineColor = outlineColor;
            this.width = Fonts.MainFont.MeasureString(text).Width * scale;
            this.height = Fonts.MainFont.MeasureString(text).Height * scale;
            this.color = color;
            this.rotation = rotation;
            this.origin = Vector2.Zero;
            if (origin[0] == 'm')
                this.origin.X = width / 2f / scale;
            else if (origin[0] == 'r')
                this.origin.X = width / scale;
            else if (origin[0] == 'l')
                this.origin.X = 0;
            else
                this.origin.X = width / 2f / scale;
            if (origin[1] == 'm')
                this.origin.Y = height / 2f / scale;
            else if (origin[1] == 'b')
                this.origin.Y = height / scale;
            else if (origin[1] == 't')
                this.origin.Y = 0;
            else
                this.origin.Y = height / 2f / scale;
            this.effects = effects;
            this.angle = angle;
            this.isHovering = false;
        }
    }
    internal class Texts
    {
        public class Maintitle
        {
            public static makeVars Title;
            public static makeVars subTitle;
            public static makeVars Play;
            public static makeVars Tutorial;
            public static makeVars Settings;
            public static makeVars Exit;
            public static makeVars Version;
            public static void Init()
            {
                Title = new makeVars("B.C.C.C", new Vector2(10, 0), 8f, Color.SkyBlue, 0f, SpriteEffects.None, "lt", true, 2f, Color.Black, 0f);
                subTitle = new makeVars("Blue-archive\nCard\nCombat\nCompetition", new Vector2(10, 150), 2f, Color.SkyBlue, 0f, SpriteEffects.None, "lt", true, 1f, Color.Black, 0f);
                Play = new makeVars("플레이", new Vector2(1500, 310), 3f, Color.White, 0f, SpriteEffects.None, "rt", true, 2f, Color.Black, 0f);
                Tutorial = new makeVars("튜토리얼", new Vector2(1500, 460), 3f, Color.White, 0f, SpriteEffects.None, "rt", true, 2f, Color.Black, 0f);
                Settings = new makeVars("설정", new Vector2(1500, 610), 3f, Color.White, 0f, SpriteEffects.None, "rt", true, 2f, Color.Black, 0f);
                Exit = new makeVars("나가기", new Vector2(1500, 760), 3f, Color.White, 0f, SpriteEffects.None, "rt", true, 2f, Color.Black, 0f);
                Version = new makeVars($"v.{Info.Version}", new Vector2(10, 890), 1f, Color.White, 0f, SpriteEffects.None, "lb", true, 1f, Color.Black, 0f);
            }
        }
        public class Settings
        {
            public static makeVars Back;
            public static makeVars Setting1;
            public static makeVars Setting2;
            public static makeVars Setting3;

            public static void Init()
            {
                Back = new makeVars("뒤로가기", new Vector2(1500, 10), 3f, Color.White, 0f, SpriteEffects.None, "rt", true, 2f, Color.Black, 0f);
                Setting1 = new makeVars("대충 설정1", new Vector2(1500, 310), 3f, Color.White, 0f, SpriteEffects.None, "rt", true, 2f, Color.Black, 0f);
                Setting2 = new makeVars("대충 설정2", new Vector2(1500, 460), 3f, Color.White, 0f, SpriteEffects.None, "rt", true, 2f, Color.Black, 0f);
                Setting3 = new makeVars("대충 설정3", new Vector2(1500, 610), 3f, Color.White, 0f, SpriteEffects.None, "rt", true, 2f, Color.Black, 0f);
            }
        }
        public class SelectSaveFiles()
        {
            public static makeVars Back;
            public static makeVars SaveFile1;
            public static makeVars SaveFile2;
            public static makeVars SaveFile3;
            public static makeVars NextPage;
            public static makeVars PrivPage;
            public static makeVars Page;
            public static void Init()
            {
                Back = new makeVars("뒤로가기", new Vector2(1500, 10), 3f, Color.White, 0f, SpriteEffects.None, "rt", true, 2f, Color.Black, 0f);
                NextPage = new makeVars("다음", new Vector2(1500, 890), 3f, Color.White, 0f, SpriteEffects.None, "rb", true, 2f, Color.Black, 0f);
                PrivPage = new makeVars("이전", new Vector2(900, 890), 3f, Color.White, 0f, SpriteEffects.None, "lb", true, 2f, Color.Black, 0f);
                SaveFile1 = new makeVars("", new Vector2(1500, 310), 3f, Color.White, 0f, SpriteEffects.None, "rt", true, 2f, Color.Black, 0f);
                SaveFile2 = new makeVars("", new Vector2(1500, 460), 3f, Color.White, 0f, SpriteEffects.None, "rt", true, 2f, Color.Black, 0f);
                SaveFile3 = new makeVars("", new Vector2(1500, 610), 3f, Color.White, 0f, SpriteEffects.None, "rt", true, 2f, Color.Black, 0f);
                Page = new makeVars("(1/4)", new Vector2(1200, 890), 3f, Color.White, 0f, SpriteEffects.None, "mb", true, 2f, Color.Black, 0f);
            }
            public static void SelectReset(string one, string two, string three)
            {
                SaveFile1 = new makeVars(one, new Vector2(1500, 310), 3f, Color.White, 0f, SpriteEffects.None, "rt", true, 2f, Color.Black, 0f);
                SaveFile2 = new makeVars(two, new Vector2(1500, 460), 3f, Color.White, 0f, SpriteEffects.None, "rt", true, 2f, Color.Black, 0f);
                SaveFile3 = new makeVars(three, new Vector2(1500, 610), 3f, Color.White, 0f, SpriteEffects.None, "rt", true, 2f, Color.Black, 0f);
                Page.text = $"({States.SelectPlayer + 1}/4)";
            }
        }

        public static void Init()
        {
            Maintitle.Init();
            Settings.Init();
            SelectSaveFiles.Init();
        }

        public static void Update()
        {
            switch (States.currentState)
            {
                case 0: // 메인메뉴
                    MouseHover.Check(Maintitle.Play);
                    MouseHover.Check(Maintitle.Tutorial);
                    MouseHover.Check(Maintitle.Settings);
                    MouseHover.Check(Maintitle.Exit);
                    break;
                case 1: // 튜토리얼
                    break;
                case 2: // 설정
                    MouseHover.Check(Settings.Back);
                    MouseHover.Check(Settings.Setting1);
                    MouseHover.Check(Settings.Setting2);
                    MouseHover.Check(Settings.Setting3);
                    break;
                case 3: // 세이브파일 선택
                    MouseHover.Check(SelectSaveFiles.Back);
                    MouseHover.Check(SelectSaveFiles.SaveFile1);
                    MouseHover.Check(SelectSaveFiles.SaveFile2);
                    MouseHover.Check(SelectSaveFiles.SaveFile3);
                    MouseHover.Check(SelectSaveFiles.NextPage);
                    MouseHover.Check(SelectSaveFiles.PrivPage);
                    break;
                case 4: // 게임
                    break;
                default:
                    break;
            }
        }
    }
}
