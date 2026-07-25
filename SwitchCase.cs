using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BCCC
{
    internal class SwitchCase
    {
        public static void DrawDisplay()
        {
            switch (States.currentState)
            {
                case -1: // 로딩
                    States.currentState = 0; // 나중에 그냥 로딩화면 추가하렴
                    break;
                case 0: // 메인
                    SpriteBatch.Maintitle();
                    if (Texts.Maintitle.Play.isHovering && Game1.LeftMouse)
                    {
                        States.currentState = 3; // 세이브파일 선택
                    }
                    if (Texts.Maintitle.Tutorial.isHovering && Game1.LeftMouse)
                    {
                        States.currentState = 1; // 튜토리얼
                    }
                    if (Texts.Maintitle.Settings.isHovering && Game1.LeftMouse)
                    {
                        States.currentState = 2; // 설정
                    }
                    if (Texts.Maintitle.Exit.isHovering && Game1.LeftMouse)
                    {
                        States.exit = true; // 종료
                    }
                    break;
                case 1: // 튜토리얼
                    break;
                case 2: // 설정
                    SpriteBatch.Settings();
                    if ((Texts.Settings.Back.isHovering && Game1.LeftMouse) || Game1.escPressed)
                    {
                        States.currentState = 0; // 메인
                    }
                    break;
                case 3: // 세이브파일 선택
                    SpriteBatch.SelectSaveFiles();
                    if ((Texts.SelectSaveFiles.Back.isHovering && Game1.LeftMouse) || Game1.escPressed)
                    {
                        States.currentState = 0; // 메인
                    }
                    break;
                case 4: // 게임
                    break;
                default: // 예외 처리(그냥 메인화면으로가기)
                    States.currentState = 0;
                    break;
            }
        }

    }
}
