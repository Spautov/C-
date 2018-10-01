using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemeDev
{
    public class Card
    {
        private CardSuits _suit;
        private CardType _type;
        public CardSuits Suit
        {
            get { return _suit; }
            private set { }
        }

        public CardType Type
        {
            get { return _type; }
            private set { }
        }

        public Card(CardType type, CardSuits suit)
        {
            _type = type;
            _suit = suit;
        }

        public override string ToString()
        {
            string suit;
            string type;
            switch (_suit)
            {
                case CardSuits.DIAMNDS:
                    suit = "бубен";
                    break;
                case CardSuits.CLUBS:
                    suit = "треф";
                    break;
                case CardSuits.SPADES:
                    suit = "пик";
                    break;
                case CardSuits.HEARTS:
                    suit = "червей";
                    break;
                default:
                    suit = "";
                    break;
            }

            switch (_type)
            {
                case CardType.SIX:
                    type = "шестерка";
                    break;
                case CardType.SEVEN:
                    type = "семерка";
                    break;
                case CardType.EIGHT:
                    type = "восьмерка";
                    break;
                case CardType.NINE:
                    type = "девятка";
                    break;
                case CardType.TEN:
                    type = "десятка";
                    break;
                case CardType.JACK:
                    type = "валет";
                    break;
                case CardType.QUEEN:
                    type = "дама";
                    break;
                case CardType.KING:
                    type = "король";
                    break;
                case CardType.ACE:
                    type = "туз";
                    break;
                default:
                    type = "";
                    break;
            }
            return String.Format("{0} {1}", type, suit);
        }
    }

    public enum CardType
    {
        SIX = 6,
        SEVEN,
        EIGHT,
        NINE,
        TEN,
        JACK,
        QUEEN,
        KING,
        ACE
    }

    public enum CardSuits
    {
        HEARTS,
        DIAMNDS,
        CLUBS,
        SPADES
    }
}
