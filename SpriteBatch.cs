using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace BCCC
{
    internal class SpriteBatch
    {
        public static void Maintitle()
        {
            Game1.Batch.TextStart();
            Game1.Batch.Text(Texts.Maintitle.Title.text, Texts.Maintitle.Title.pos, Texts.Maintitle.Title.scale, Texts.Maintitle.Title.color, Texts.Maintitle.Title.outline, Texts.Maintitle.Title.outlineColor, Texts.Maintitle.Title.thin, Fonts.MainFont, Texts.Maintitle.Title.angle, Texts.Maintitle.Title.origin);
            Game1.Batch.Text(Texts.Maintitle.subTitle.text, Texts.Maintitle.subTitle.pos, Texts.Maintitle.subTitle.scale, Texts.Maintitle.subTitle.color, Texts.Maintitle.subTitle.outline, Texts.Maintitle.subTitle.outlineColor, Texts.Maintitle.subTitle.thin, Fonts.MainFont, Texts.Maintitle.subTitle.angle, Texts.Maintitle.subTitle.origin);
            Game1.Batch.Text(Texts.Maintitle.Play.text, Texts.Maintitle.Play.pos, Texts.Maintitle.Play.scale, Texts.Maintitle.Play.color, Texts.Maintitle.Play.outline, Texts.Maintitle.Play.outlineColor, Texts.Maintitle.Play.thin, Fonts.MainFont, Texts.Maintitle.Play.angle, Texts.Maintitle.Play.origin);
            Game1.Batch.Text(Texts.Maintitle.Tutorial.text, Texts.Maintitle.Tutorial.pos, Texts.Maintitle.Tutorial.scale, Texts.Maintitle.Tutorial.color, Texts.Maintitle.Tutorial.outline, Texts.Maintitle.Tutorial.outlineColor, Texts.Maintitle.Tutorial.thin, Fonts.MainFont, Texts.Maintitle.Tutorial.angle, Texts.Maintitle.Tutorial.origin);
            Game1.Batch.Text(Texts.Maintitle.Settings.text, Texts.Maintitle.Settings.pos, Texts.Maintitle.Settings.scale, Texts.Maintitle.Settings.color, Texts.Maintitle.Settings.outline, Texts.Maintitle.Settings.outlineColor, Texts.Maintitle.Settings.thin, Fonts.MainFont, Texts.Maintitle.Settings.angle, Texts.Maintitle.Settings.origin);
            Game1.Batch.Text(Texts.Maintitle.Exit.text, Texts.Maintitle.Exit.pos, Texts.Maintitle.Exit.scale, Texts.Maintitle.Exit.color, Texts.Maintitle.Exit.outline, Texts.Maintitle.Exit.outlineColor, Texts.Maintitle.Exit.thin, Fonts.MainFont, Texts.Maintitle.Exit.angle, Texts.Maintitle.Exit.origin);
            Game1.Batch.Text(Texts.Maintitle.Version.text, Texts.Maintitle.Version.pos, Texts.Maintitle.Version.scale, Texts.Maintitle.Version.color, Texts.Maintitle.Version.outline, Texts.Maintitle.Version.outlineColor, Texts.Maintitle.Version.thin, Fonts.MainFont, Texts.Maintitle.Version.angle, Texts.Maintitle.Version.origin);
            MouseHover.Cover(Texts.Maintitle.Play);
            MouseHover.Cover(Texts.Maintitle.Tutorial);
            MouseHover.Cover(Texts.Maintitle.Settings);
            MouseHover.Cover(Texts.Maintitle.Exit);
            Game1.Batch.End();
        }
        public static void Settings()
        {
            Game1.Batch.TextStart();
            Game1.Batch.Text(Texts.Settings.Title.text, Texts.Settings.Title.pos, Texts.Settings.Title.scale, Texts.Settings.Title.color, Texts.Settings.Title.outline, Texts.Settings.Title.outlineColor, Texts.Settings.Title.thin, Fonts.MainFont, Texts.Settings.Title.angle, Texts.Settings.Title.origin);
            Game1.Batch.Text(Texts.Settings.Setting1.text, Texts.Settings.Setting1.pos, Texts.Settings.Setting1.scale, Texts.Settings.Setting1.color, Texts.Settings.Setting1.outline, Texts.Settings.Setting1.outlineColor, Texts.Settings.Setting1.thin, Fonts.MainFont, Texts.Settings.Setting1.angle, Texts.Settings.Setting1.origin);
            Game1.Batch.Text(Texts.Settings.Setting2.text, Texts.Settings.Setting2.pos, Texts.Settings.Setting2.scale, Texts.Settings.Setting2.color, Texts.Settings.Setting2.outline, Texts.Settings.Setting2.outlineColor, Texts.Settings.Setting2.thin, Fonts.MainFont, Texts.Settings.Setting2.angle, Texts.Settings.Setting2.origin);
            Game1.Batch.Text(Texts.Settings.Setting3.text, Texts.Settings.Setting3.pos, Texts.Settings.Setting3.scale, Texts.Settings.Setting3.color, Texts.Settings.Setting3.outline, Texts.Settings.Setting3.outlineColor, Texts.Settings.Setting3.thin, Fonts.MainFont, Texts.Settings.Setting3.angle, Texts.Settings.Setting3.origin);
            MouseHover.Cover(Texts.Settings.Setting1);
            MouseHover.Cover(Texts.Settings.Setting2);
            MouseHover.Cover(Texts.Settings.Setting3); 
            Game1.Batch.End();
        }
    }
}
