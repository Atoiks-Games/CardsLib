using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsLib
{
    public class Dealer
    {

        private static readonly Random RND_GEN = new Random();

        public static List<Card> Deal(int count)
        {
            var cards = new List<Card>();
            while (count-- > 0)
            {
                cards.Add(new Card(RND_GEN.Next(0, 52)));
            }
            return cards;
        }
    }
}
