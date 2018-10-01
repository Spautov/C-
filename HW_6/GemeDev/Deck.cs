using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemeDev
{
    public class Deck
    {
       
        private List<Card> _packOfCards;
        public Deck()
        {
            _packOfCards = new List<Card>(36);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 6; j < 15; j++)
                {
                    _packOfCards.Add(new Card((CardType)j, (CardSuits)i));
                }

            }
        }

        public void Shuffle()
        {
            Random random = new Random();
            for (int i = 0; i < 300; i++)
            {
                int first;
                int last;
                first = random.Next(0, 35);
                do
                {
                    last = random.Next(0, 35);
                } while (last == first);
                TradePlaces(first, last);
            }
        }

        private void TradePlaces(int firstInd, int lastInd)
        {
            if (firstInd >= 0 && lastInd >= 0 && lastInd < 36
                && firstInd < 36 && firstInd != lastInd)
            {
                Card temp;
                temp = _packOfCards[firstInd];
                _packOfCards[firstInd] = _packOfCards[lastInd];
                _packOfCards[lastInd] = temp;
            }
        }

        public int Count
        {
            get { return _packOfCards.Count; }
            private set { }
        }

        public Card GetCard
        {
            get
            {
                if (_packOfCards.Count > 0)
                {
                    Card cardTmp;
                    cardTmp = _packOfCards.Last();
                    _packOfCards.RemoveAt(_packOfCards.Count - 1);
                    return cardTmp;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            private set { }
        }
    }

}
