using System;
using System.Collections.Generic;
using System.Text;

namespace EnteringTheCatacombs
{
    internal class Card
    {
        public enum Rank  //an enum to hold my card ranks
        {
            One,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Dollar,
            Percent,
            Caret,
            Ampersand
        }
        public enum CardColor
        {
            Red,
            Green,
            Blue,
            Yellow
        }

        public Rank CardRank { get; set; }
        public CardColor Color { get; set; }
        public Card(CardColor color, Rank rank)
        {
            CardRank = rank;
            Color = color;
        }

        public string GetCardType()
        {
            if ((int)CardRank <= 9)  //cast the enum to check if its a number or symbol card            
            {
                return "Number Card";
            }
            else
            {
                return "Symbol Card";
            }
        }

        public override string ToString()
        {
            return $"The {Color} {CardRank}";
        }
    }
}
