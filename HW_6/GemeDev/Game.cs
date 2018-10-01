using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemeDev
{
    public class Game
    {
        private bool _isGameOver;
        private int _countMove;
        private List<Player> _players;
        private Player _winner;
        public Dictionary<Card, Player> _gameField;
        public Queue<KeyValuePair<Player, int>> _playerGemeOver;
        public Deck deck;

        public Game()
        {
            Random rnd = new Random();
            int countPlayers;
            do
            {
                countPlayers = rnd.Next(2, 7);
            } while (countPlayers == 5);
            _players = new List<Player>(countPlayers);
            string name;
            for (int i = 0; i < countPlayers; i++)
            {
                name = String.Format("Игрок №{0}", i);
                _players.Add(new Player(name));
            }
            deck = new Deck();
            _gameField = new Dictionary<Card, Player>();
            _playerGemeOver = new Queue<KeyValuePair<Player, int>>();
            foreach (var item in _players)
            {
                item.WinnGame += EndGeme;
            }

        }

        public void DistributeCards()
        {
            while (deck.Count > 0)
            {
                for (int i = 0; i < _players.Count; i++)
                {
                    _players[i].PackOfCards = deck.GetCard;
                }
            }
        }

        public void Play()
        {
            deck.Shuffle();
            DistributeCards();
            Console.WriteLine("Всего игроков {0}", _players.Count);
            Console.WriteLine("Шаг {0}", _countMove);
            while (!_isGameOver)
            {
                _countMove++;
                _gameField.Clear();
                
                if (_countMove % 10000 == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Всего игроков {0}", _players.Count);
                    Console.WriteLine("Шаг {0}", _countMove);
                }
                
                //-----
                int i = 0;
                foreach (var item in _players)
                {
                    //---------
                   // Console.WriteLine(++i);
                    _gameField.Add(item.GetCard(), item);
                }
                Check(_gameField);
                
            }
            Console.WriteLine("Всего игроков {0}", _playerGemeOver.Count+1);
            Console.WriteLine("Всего ходов {0}", _countMove);
            Console.WriteLine("Победил игрок {0}", _winner.Name);
            Console.WriteLine("Игроки выбывали в следующем порядке:");
            KeyValuePair<Player, int> queueOFF;
            while (_playerGemeOver.Count>0)
            {
                queueOFF = _playerGemeOver.Dequeue();
                Console.WriteLine("{0} на {1} шаге", queueOFF.Key.Name, queueOFF.Value);
            }
            
        }
         
        private void Check(Dictionary<Card, Player> cardPack)
        {
            bool contin = false;
            for (int i = 14; i >= 6; i--)
            {
                foreach (var item in cardPack)
                {
                    if (item.Key.Type == (CardType)i)
                    {
                        item.Value.SetCards(cardPack.Keys.ToArray());
                        contin = true;
                        break;
                    }

                }
                if (contin)
                {
                    break;
                }

            }

            foreach (var item in _players)
            {
                if (item.CountCards==0)
                {
                    _playerGemeOver.Enqueue(new KeyValuePair<Player, int>(item, _countMove));
                }
            }

            foreach (var item in _playerGemeOver)
            {
                _players.Remove(item.Key);
            }
        }


        public int NumberMove
        {
            get { return _countMove; }
            private set { }
        }

        public void EndGeme(Object obj, EventArgs e)
        {
            _isGameOver = true;
            _winner = (Player)obj;
        }
    }
}
