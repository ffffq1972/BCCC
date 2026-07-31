using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Microsoft.Xna.Framework.Media;

namespace BCCC
{
    internal class Info
    {
        public static string Version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        public static string GameName = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyTitleAttribute>()?.Title ?? "이름 불러오는거(Info.cs) 에러났으니깐 고치시오";
        public static string Title = Assembly.GetExecutingAssembly().GetCustomAttribute<AssemblyProductAttribute>()?.Product ?? "이름 불러오는거(Info.cs) 에러났으니깐 고치시오 22";
        public static int mywidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
        public static int myheight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
        public static int width = 1600;
        public static int height = 900;
        public static float Wh = (float)width / mywidth;
        public static float wH = (float)height / myheight;
        public static int players = 0; // 플레이어 수(만든 플레이어 데이터 수임)
        public static int maxPlayers = 3; // 4페이지 (플레이어 데이터 수 총 12개까지)
        public static List<string> Playerlist = new List<string> {"새로 만들기", "새로 만들기", "새로 만들기", "새로 만들기", "새로 만들기", "새로 만들기", "새로 만들기", "새로 만들기", "새로 만들기", "새로 만들기", "새로 만들기", "새로 만들기"};
    }

    internal class newPlayer
    {
        public string Name;
        public int Difficult;
        public List<newStriker> Strikers;
        public List<newSpecial> Specials;
        public List<newGoods> Goods;
        public int Level;
        public int XP;
        public newPlayer(string Name, int Difficult, List<newStriker> Strikers, List<newSpecial> Specials, List<newGoods> Goods, int Level = 1, int XP = 0)
        {
            this.Name = Name;
            this.Difficult = Difficult;
            this.Strikers = Strikers;
            this.Specials = Specials;
            this.Goods = Goods;
            this.Level = Level;
            this.XP = XP;
        }
    }
}
