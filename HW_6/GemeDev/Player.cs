using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemeDev
{
    public class Player
    {
        private Queue<Card> _packOfCards;
        private string _name;
        public int CountCards
        {
            get { return _packOfCards.Count; }
            private set { }
        }

        public Player(string name)
        {
            _packOfCards = new Queue<Card>();
            _name = name;
        }

        public string Name
        {
            get { return _name; }
            private set { }
        }
        public Card PackOfCards                                 
        {                                                      
            set                                                 
            {                                                   
                _packOfCards.Enqueue(value);                   
                if (_packOfCards.Count >= 36)                   
                {                                               
                    WinnGame(this, EventArgs.Empty);            
                }                                               
            }                                                   
        }                                                       
        public Card GetCard()
        {
            return _packOfCards.Dequeue();
        }   
        
        public void SetCards(Card[] cards)
        {
            //-------
            //for (int i = cards.Count()-1; i >=0 ; i--)
            //{
            //    _packOfCards.Enqueue(cards[i]);
            //    if (_packOfCards.Count >= 36)
            //    {
            //        WinnGame(this, EventArgs.Empty);
            //    }
            //}


            //------------------


            foreach (var elem in cards)
            {
                _packOfCards.Enqueue(elem);
                if (_packOfCards.Count >= 36)
                {
                    WinnGame(this, EventArgs.Empty);
                }
            }
        }
        public event EventHandler WinnGame;

    }
}
