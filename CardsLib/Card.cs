using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsLib
{
    public class Card
    {
        //declare variables.
        private int pIntNumber;
        private int pIntCardValue;
        private string pStrSuit;

        //Constructor.
        public Card(int intCardNumber)
        {
            pIntNumber = intCardNumber;
            pIntCardValue = intCardNumber % 13;

            if (pIntNumber > 0 && pIntNumber < 14)
            {
                pStrSuit = "Spades";
            }
            else if (pIntNumber < 27)
            {
                pStrSuit = "Hearts";
            }
            else if (pIntNumber < 40)
            {
                pStrSuit = "Clubs";
            }
            else if (pIntNumber < 53)
            {
                pStrSuit = "Diamonds";
            }
            else throw new ArgumentException("Illegal card number provided");
        }

        //encapsulation. Accessor methods for card data.
        public int intCardNumber
        {
            set
            {
                pIntNumber = intCardNumber;
            }
            get
            {
                return pIntNumber;
            }
        }
        public int intCardValue
        {
            set
            {
                pIntCardValue = intCardValue;
            }
            get
            {
                return pIntCardValue;
            }
        }

        public string strCardSuit
        {
            set
            {
                pStrSuit = strCardSuit;
            }
            get
            {
                return pStrSuit;
            }
        }

        private string processCardVal(int cardVal)
        {
            var msg = "";
            switch (cardVal)
            {
                case 11:
                    msg = "Jack";
                    break;
                case 12:
                    msg = "Queen";
                    break;
                case 13:
                    msg = "King";
                    break;
                default:
                    msg = cardVal.ToString();
                    break;
            }
            return msg;
        }

        public override string ToString()
        {
            return strCardSuit + ":" + processCardVal(intCardValue + 1);
        }

        public override bool Equals(object obj)
        {
            var card2 = obj as Card;
            if (!this.pStrSuit.Equals(card2.pStrSuit))
                return false;
            if (this.pIntNumber != card2.pIntNumber)
                return false;
            if (this.pIntCardValue != card2.pIntCardValue)
                return false;
            return true;
        }

        public override int GetHashCode()
        {
            int val = 37;
            val = val * 17 + this.pIntCardValue;
            val = val * 17 + this.pIntNumber;
            val = val * 17 + this.pStrSuit.GetHashCode();
            return val;
        }
    }
}
