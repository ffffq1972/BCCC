using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
    }
}
