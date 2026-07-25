using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using SharpDX.Direct2D1.Effects;

namespace BCCC
{
    internal class MouseHover
    {
        /// <summary>
        /// 마우스 호버 체크
        /// </summary>
        /// <param name="var1">makeVars</param>
        public static void Check(makeVars var1)
        {
            if (
                Game1.mouseState.X >= var1.pos.X - Math.Abs(var1.origin.X * var1.scale) - 10 &&
                Game1.mouseState.X <= var1.pos.X - Math.Abs(var1.origin.X * var1.scale) + 10 + var1.width &&
                Game1.mouseState.Y <= var1.pos.Y - Math.Abs(var1.origin.Y * var1.scale) + 10 + var1.height &&
                Game1.mouseState.Y >= var1.pos.Y - Math.Abs(var1.origin.Y * var1.scale) - 10
                )
            { 
                var1.isHovering = true;
            }
            else
            {
                var1.isHovering = false;
            }
        }
        
        public static void Cover(makeVars var1, Color color = default)
        {
            if (color == default)
            {
                color = Color.Black;
            }
            if (var1.isHovering)
            {
                float textleftpos = var1.pos.X - (var1.origin.X * var1.scale);
                float textrightpos = textleftpos + var1.width;
                float texttoppos = var1.pos.Y - (var1.origin.Y * var1.scale);
                Vector2 origin1 = new Vector2(Fonts.MainFont.MeasureString("[").Width / 2f, 0);
                Game1.Batch.Text("[", new Vector2(textleftpos - (origin1.X / 2f * var1.scale) - (origin1.X * var1.scale), texttoppos), var1.scale, var1.color, true, color, var1.thin, Fonts.MainFont, var1.angle, origin1);
                Game1.Batch.Text("]", new Vector2(textrightpos + (origin1.X / 2f * var1.scale) + (origin1.X * var1.scale), texttoppos), var1.scale, var1.color, true, color, var1.thin, Fonts.MainFont, var1.angle, origin1);
            }
        }
    }

    internal class Display
    {
        
    }
}
