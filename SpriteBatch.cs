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
        private static void DrawTitle()
        {
            Game1.Batch.Text(Texts.Maintitle.Title.text, Texts.Maintitle.Title.pos, Texts.Maintitle.Title.scale, Texts.Maintitle.Title.color, Texts.Maintitle.Title.outline, Texts.Maintitle.Title.outlineColor, Texts.Maintitle.Title.thin, Fonts.MainFont, Texts.Maintitle.Title.angle, Texts.Maintitle.Title.origin);
            Game1.Batch.Text(Texts.Maintitle.subTitle.text, Texts.Maintitle.subTitle.pos, Texts.Maintitle.subTitle.scale, Texts.Maintitle.subTitle.color, Texts.Maintitle.subTitle.outline, Texts.Maintitle.subTitle.outlineColor, Texts.Maintitle.subTitle.thin, Fonts.MainFont, Texts.Maintitle.subTitle.angle, Texts.Maintitle.subTitle.origin);
            Game1.Batch.Text(Texts.Maintitle.Version.text, Texts.Maintitle.Version.pos, Texts.Maintitle.Version.scale, Texts.Maintitle.Version.color, Texts.Maintitle.Version.outline, Texts.Maintitle.Version.outlineColor, Texts.Maintitle.Version.thin, Fonts.MainFont, Texts.Maintitle.Version.angle, Texts.Maintitle.Version.origin);
        }
        public static void Maintitle()
        {
            Game1.Batch.TextStart();
            DrawTitle();
            Game1.Batch.Text(Texts.Maintitle.Play.text, Texts.Maintitle.Play.pos, Texts.Maintitle.Play.scale, Texts.Maintitle.Play.color, Texts.Maintitle.Play.outline, Texts.Maintitle.Play.outlineColor, Texts.Maintitle.Play.thin, Fonts.MainFont, Texts.Maintitle.Play.angle, Texts.Maintitle.Play.origin);
            Game1.Batch.Text(Texts.Maintitle.Tutorial.text, Texts.Maintitle.Tutorial.pos, Texts.Maintitle.Tutorial.scale, Texts.Maintitle.Tutorial.color, Texts.Maintitle.Tutorial.outline, Texts.Maintitle.Tutorial.outlineColor, Texts.Maintitle.Tutorial.thin, Fonts.MainFont, Texts.Maintitle.Tutorial.angle, Texts.Maintitle.Tutorial.origin);
            Game1.Batch.Text(Texts.Maintitle.Settings.text, Texts.Maintitle.Settings.pos, Texts.Maintitle.Settings.scale, Texts.Maintitle.Settings.color, Texts.Maintitle.Settings.outline, Texts.Maintitle.Settings.outlineColor, Texts.Maintitle.Settings.thin, Fonts.MainFont, Texts.Maintitle.Settings.angle, Texts.Maintitle.Settings.origin);
            Game1.Batch.Text(Texts.Maintitle.Exit.text, Texts.Maintitle.Exit.pos, Texts.Maintitle.Exit.scale, Texts.Maintitle.Exit.color, Texts.Maintitle.Exit.outline, Texts.Maintitle.Exit.outlineColor, Texts.Maintitle.Exit.thin, Fonts.MainFont, Texts.Maintitle.Exit.angle, Texts.Maintitle.Exit.origin);
            MouseHover.Cover(Texts.Maintitle.Play);
            MouseHover.Cover(Texts.Maintitle.Tutorial);
            MouseHover.Cover(Texts.Maintitle.Settings);
            MouseHover.Cover(Texts.Maintitle.Exit);
            Game1.Batch.End();
        }
        public static void Settings()
        {
            Game1.Batch.TextStart();
            DrawTitle();
            Game1.Batch.Text(Texts.Settings.Back.text, Texts.Settings.Back.pos, Texts.Settings.Back.scale, Texts.Settings.Back.color, Texts.Settings.Back.outline, Texts.Settings.Back.outlineColor, Texts.Settings.Back.thin, Fonts.MainFont, Texts.Settings.Back.angle, Texts.Settings.Back.origin);
            Game1.Batch.Text(Texts.Settings.Setting1.text, Texts.Settings.Setting1.pos, Texts.Settings.Setting1.scale, Texts.Settings.Setting1.color, Texts.Settings.Setting1.outline, Texts.Settings.Setting1.outlineColor, Texts.Settings.Setting1.thin, Fonts.MainFont, Texts.Settings.Setting1.angle, Texts.Settings.Setting1.origin);
            Game1.Batch.Text(Texts.Settings.Setting2.text, Texts.Settings.Setting2.pos, Texts.Settings.Setting2.scale, Texts.Settings.Setting2.color, Texts.Settings.Setting2.outline, Texts.Settings.Setting2.outlineColor, Texts.Settings.Setting2.thin, Fonts.MainFont, Texts.Settings.Setting2.angle, Texts.Settings.Setting2.origin);
            Game1.Batch.Text(Texts.Settings.Setting3.text, Texts.Settings.Setting3.pos, Texts.Settings.Setting3.scale, Texts.Settings.Setting3.color, Texts.Settings.Setting3.outline, Texts.Settings.Setting3.outlineColor, Texts.Settings.Setting3.thin, Fonts.MainFont, Texts.Settings.Setting3.angle, Texts.Settings.Setting3.origin);
            MouseHover.Cover(Texts.Settings.Back);
            MouseHover.Cover(Texts.Settings.Setting1);
            MouseHover.Cover(Texts.Settings.Setting2);
            MouseHover.Cover(Texts.Settings.Setting3); 
            Game1.Batch.End();
        }
        public static void SelectSaveFiles()
        {
            Game1.Batch.TextStart();
            DrawTitle();
            Game1.Batch.Text(Texts.SelectSaveFiles.Back.text, Texts.SelectSaveFiles.Back.pos, Texts.SelectSaveFiles.Back.scale, Texts.SelectSaveFiles.Back.color, Texts.SelectSaveFiles.Back.outline, Texts.SelectSaveFiles.Back.outlineColor, Texts.SelectSaveFiles.Back.thin, Fonts.MainFont, Texts.SelectSaveFiles.Back.angle, Texts.SelectSaveFiles.Back.origin);
            if (States.SelectPlayer > 0)
            {
                Game1.Batch.Text(Texts.SelectSaveFiles.PrivPage.text, Texts.SelectSaveFiles.PrivPage.pos, Texts.SelectSaveFiles.PrivPage.scale, Texts.SelectSaveFiles.PrivPage.color, Texts.SelectSaveFiles.PrivPage.outline, Texts.SelectSaveFiles.PrivPage.outlineColor, Texts.SelectSaveFiles.PrivPage.thin, Fonts.MainFont, Texts.SelectSaveFiles.PrivPage.angle, Texts.SelectSaveFiles.PrivPage.origin);
            }
            if (States.SelectPlayer < 3)
            {
                Game1.Batch.Text(Texts.SelectSaveFiles.NextPage.text, Texts.SelectSaveFiles.NextPage.pos, Texts.SelectSaveFiles.NextPage.scale, Texts.SelectSaveFiles.NextPage.color, Texts.SelectSaveFiles.NextPage.outline, Texts.SelectSaveFiles.NextPage.outlineColor, Texts.SelectSaveFiles.NextPage.thin, Fonts.MainFont, Texts.SelectSaveFiles.NextPage.angle, Texts.SelectSaveFiles.NextPage.origin);
            }
            Game1.Batch.Text(Texts.SelectSaveFiles.Page.text, Texts.SelectSaveFiles.Page.pos, Texts.SelectSaveFiles.Page.scale, Texts.SelectSaveFiles.Page.color, Texts.SelectSaveFiles.Page.outline, Texts.SelectSaveFiles.Page.outlineColor, Texts.SelectSaveFiles.Page.thin, Fonts.MainFont, Texts.SelectSaveFiles.Page.angle, Texts.SelectSaveFiles.Page.origin);
            Game1.Batch.Text(Texts.SelectSaveFiles.SaveFile1.text, Texts.SelectSaveFiles.SaveFile1.pos, Texts.SelectSaveFiles.SaveFile1.scale, Texts.SelectSaveFiles.SaveFile1.color, Texts.SelectSaveFiles.SaveFile1.outline, Texts.SelectSaveFiles.SaveFile1.outlineColor, Texts.SelectSaveFiles.SaveFile1.thin, Fonts.MainFont, Texts.SelectSaveFiles.SaveFile1.angle, Texts.SelectSaveFiles.SaveFile1.origin);
            Game1.Batch.Text(Texts.SelectSaveFiles.SaveFile2.text, Texts.SelectSaveFiles.SaveFile2.pos, Texts.SelectSaveFiles.SaveFile2.scale, Texts.SelectSaveFiles.SaveFile2.color, Texts.SelectSaveFiles.SaveFile2.outline, Texts.SelectSaveFiles.SaveFile2.outlineColor, Texts.SelectSaveFiles.SaveFile2.thin, Fonts.MainFont, Texts.SelectSaveFiles.SaveFile2.angle, Texts.SelectSaveFiles.SaveFile2.origin);
            Game1.Batch.Text(Texts.SelectSaveFiles.SaveFile3.text, Texts.SelectSaveFiles.SaveFile3.pos, Texts.SelectSaveFiles.SaveFile3.scale, Texts.SelectSaveFiles.SaveFile3.color, Texts.SelectSaveFiles.SaveFile3.outline, Texts.SelectSaveFiles.SaveFile3.outlineColor, Texts.SelectSaveFiles.SaveFile3.thin, Fonts.MainFont, Texts.SelectSaveFiles.SaveFile3.angle, Texts.SelectSaveFiles.SaveFile3.origin);
            MouseHover.Cover(Texts.SelectSaveFiles.Back);
            if (States.SelectPlayer > 0)
            {
                MouseHover.Cover(Texts.SelectSaveFiles.PrivPage);
            }
            if (States.SelectPlayer < 3)
            {
                MouseHover.Cover(Texts.SelectSaveFiles.NextPage);
            }
            MouseHover.Cover(Texts.SelectSaveFiles.SaveFile1);
            MouseHover.Cover(Texts.SelectSaveFiles.SaveFile2);
            MouseHover.Cover(Texts.SelectSaveFiles.SaveFile3);
            Game1.Batch.End();
        }
        public static void AddPlayer()
        {
            Game1.Batch.TextStart();
            Game1.Batch.Text(Texts.AddPlayer.Back.text, Texts.AddPlayer.Back.pos, Texts.AddPlayer.Back.scale, Texts.AddPlayer.Back.color, Texts.AddPlayer.Back.outline, Texts.AddPlayer.Back.outlineColor, Texts.AddPlayer.Back.thin, Fonts.MainFont, Texts.AddPlayer.Back.angle, Texts.AddPlayer.Back.origin);
            Game1.Batch.Text(Texts.AddPlayer.NameInput.text, Texts.AddPlayer.NameInput.pos, Texts.AddPlayer.NameInput.scale, Texts.AddPlayer.NameInput.color, Texts.AddPlayer.NameInput.outline, Texts.AddPlayer.NameInput.outlineColor, Texts.AddPlayer.NameInput.thin, Fonts.MainFont, Texts.AddPlayer.NameInput.angle, Texts.AddPlayer.NameInput.origin);
            Game1.Batch.Text(Texts.AddPlayer.PrivDeck.text, Texts.AddPlayer.PrivDeck.pos, Texts.AddPlayer.PrivDeck.scale, Texts.AddPlayer.PrivDeck.color, Texts.AddPlayer.PrivDeck.outline, Texts.AddPlayer.PrivDeck.outlineColor, Texts.AddPlayer.PrivDeck.thin, Fonts.MainFont, Texts.AddPlayer.PrivDeck.angle, Texts.AddPlayer.PrivDeck.origin);
            Game1.Batch.Text(Texts.AddPlayer.NextDeck.text, Texts.AddPlayer.NextDeck.pos, Texts.AddPlayer.NextDeck.scale, Texts.AddPlayer.NextDeck.color, Texts.AddPlayer.NextDeck.outline, Texts.AddPlayer.NextDeck.outlineColor, Texts.AddPlayer.NextDeck.thin, Fonts.MainFont, Texts.AddPlayer.NextDeck.angle, Texts.AddPlayer.NextDeck.origin);
            Game1.Batch.Text(Texts.AddPlayer.PrivDifficult.text, Texts.AddPlayer.PrivDifficult.pos, Texts.AddPlayer.PrivDifficult.scale, Texts.AddPlayer.PrivDifficult.color, Texts.AddPlayer.PrivDifficult.outline, Texts.AddPlayer.PrivDifficult.outlineColor, Texts.AddPlayer.PrivDifficult.thin, Fonts.MainFont, Texts.AddPlayer.PrivDifficult.angle, Texts.AddPlayer.PrivDifficult.origin);
            Game1.Batch.Text(Texts.AddPlayer.NextDifficult.text, Texts.AddPlayer.NextDifficult.pos, Texts.AddPlayer.NextDifficult.scale, Texts.AddPlayer.NextDifficult.color, Texts.AddPlayer.NextDifficult.outline, Texts.AddPlayer.NextDifficult.outlineColor, Texts.AddPlayer.NextDifficult.thin, Fonts.MainFont, Texts.AddPlayer.NextDifficult.angle, Texts.AddPlayer.NextDifficult.origin);
            Game1.Batch.Text(Texts.AddPlayer.Complete.text, Texts.AddPlayer.Complete.pos, Texts.AddPlayer.Complete.scale, Texts.AddPlayer.Complete.color, Texts.AddPlayer.Complete.outline, Texts.AddPlayer.Complete.outlineColor, Texts.AddPlayer.Complete.thin, Fonts.MainFont, Texts.AddPlayer.Complete.angle, Texts.AddPlayer.Complete.origin);
            MouseHover.Cover(Texts.AddPlayer.Back);
            MouseHover.Cover(Texts.AddPlayer.NameInput);
            MouseHover.Cover(Texts.AddPlayer.PrivDeck);
            MouseHover.Cover(Texts.AddPlayer.NextDeck);
            MouseHover.Cover(Texts.AddPlayer.PrivDifficult);
            MouseHover.Cover(Texts.AddPlayer.NextDifficult);
            MouseHover.Cover(Texts.AddPlayer.Complete);
            Game1.Batch.End();
        }
    }
}
