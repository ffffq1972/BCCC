using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCCC
{
    internal class SaveData
    {
        internal class newPlayer
        {
            public string Name;
            public int Deck;
            public int Difficult;
            public int Level;
            public int XP;
            public List<newStriker> Strikers;
            public List<newSpecial> Specials;
            public List<newGoods> Goods;
            public newPlayer(string Name, int Deck, int Difficult, List<newStriker> Strikers, List<newSpecial> Specials, List<newGoods> Goods, int Level = 1, int XP = 0)
            {
                this.Name = Name;
                this.Deck = Deck;
                this.Difficult = Difficult;
                this.Strikers = Strikers;
                this.Specials = Specials;
                this.Goods = Goods;
                this.Level = Level;
                this.XP = XP;
            }
        }
    }
}
