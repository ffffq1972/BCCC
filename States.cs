using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCCC
{
    public class States
    {
        /// <summary>
        /// -1 : 로딩<br/>
        /// 00 : 메인메뉴<br/>
        /// 01 : 튜토리얼<br/>
        /// 02 : 설정<br/>
        /// 03 : 세이브파일 선택<br/>
        /// 04 : 게임<br/>
        /// 05 : 캐릭터 추가<br/>
        /// 06 : 이름 입력
        /// </summary>
        public static int currentState = -1;
        public static int SelectPlayer = 0;
        public static void ShowPlayers()
        {
            Texts.SelectSaveFiles.SaveFile1.text = Info.Playerlist[((SelectPlayer) * 3)];
            Texts.SelectSaveFiles.SaveFile2.text = Info.Playerlist[((SelectPlayer) * 3) + 1];
            Texts.SelectSaveFiles.SaveFile3.text = Info.Playerlist[((SelectPlayer) * 3) + 2];
            Texts.SelectSaveFiles.SaveFile1.text += $" - {(SelectPlayer / 3) + 1}";
            Texts.SelectSaveFiles.SaveFile2.text += $" - {(SelectPlayer / 3) + 2}";
            Texts.SelectSaveFiles.SaveFile3.text += $" - {(SelectPlayer / 3) + 3}";
        }
        public static bool exit = false;
        public static void MouseClickReset(MouseState mouse1)
        {
            Microsoft.Xna.Framework.Point mousePos = mouse1.Position; // 정수로 마우스 위치 구함
            // 좌클릭
            if (mouse1.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed && Game1.oldMouseState.LeftButton == Microsoft.Xna.Framework.Input.ButtonState.Released)
            {
                Game1.LeftMouse = true;
            }
            else
            {
                Game1.LeftMouse = false;
            }
            // 우클릭
            if (mouse1.RightButton == Microsoft.Xna.Framework.Input.ButtonState.Pressed && Game1.oldMouseState.RightButton == Microsoft.Xna.Framework.Input.ButtonState.Released)
            {
                Game1.RightMouse = true;
            }
            else
            {
                Game1.RightMouse = false;
            }
            Game1.oldMouseState = mouse1;
        }
    }
}
