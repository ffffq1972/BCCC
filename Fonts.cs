using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.BitmapFonts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCCC
{
    internal class Fonts
    {
        public static BitmapFont MainFont;
        public static void ReadFonts(GraphicsDevice graphicsDevice)
        {
            MainFont = BitmapFont.FromFile(graphicsDevice, "Content/Fonts/NeoDunggeunmoPro.fnt");
        }
    }
}
