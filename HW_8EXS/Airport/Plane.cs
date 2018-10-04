using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public class Plane
    {
        public const int MaxSpeed = 1000;
        private bool IsMaxSpedReaching;
        private bool IsFly;
        private static Plane _pPlane;
        private int _speed;
        private int _height;
        private List<Dispatcher> _dispatchers;
        private int _penalPoints;

        private Plane()
        {
            _dispatchers = new List<Dispatcher>();
        }

        public void AddDispatcher(string name)
        {
            foreach (var item in _dispatchers)
            {
                if (name.Equals(item.Name))
                {
                    throw new Exception("Диспетчер с таким именем уже существует!");
                }
            }
            Dispatcher tmpDispatcher = new Dispatcher(name);
            DataChanged += tmpDispatcher.EventProcessing;
            _dispatchers.Add(tmpDispatcher);
            throw new Exception(String.Format("Диспетчера {0} успешно добавлен", name));
        }

        public void RemoveDispatcher(string name)
        {
            if (IsFly && _dispatchers.Count == 2)
            {
                throw new Exception("Количество диспетчеров не может быть менее 2-х");
            }

            foreach (var item in _dispatchers)
            {
                if (name.Equals(item.Name))
                {
                    string tmpName = item.Name;
                    _penalPoints += item.PenalPoints;
                    DataChanged -= item.EventProcessing;
                    _dispatchers.Remove(item);
                    throw new Exception(String.Format("Диспетчера {0} успешно удален", tmpName));
                }
            }
            throw new Exception("Диспетчера с таким именем не существует!");
        }


        public static Plane GetPlane()
        {
            if (_pPlane == null)
                _pPlane = new Plane();
            return _pPlane;
        }

        public int Height
        {
            get { return _height; }
            private set { }
        }
        public int Speed
        {
            get { return _speed; }
            private set { }
        }

        public event EventHandler DataChanged;
        protected virtual void OnDataChanged()
        {
            if (!IsMaxSpedReaching && _speed>= 1000)
            {
                IsMaxSpedReaching = true;
            }
            
            if (DataChanged != null)
            {
                PlaneEventArgs eventArgs = new PlaneEventArgs();
                eventArgs.height = _height;
                eventArgs.speed = _speed;
                DataChanged(this, eventArgs);
            }
        }
        
        private bool IsCanFly()
        {
            if (_dispatchers.Count >= 2)
            {
                return true;
            }
            return false;
        }

        public void Fly()
        {
            if (!IsCanFly())
            {
                string mess;
                mess = String.Format("Полет запрещен, добавте еще {0} диспетчера", (2 - _dispatchers.Count));
                throw new Exception(mess);
            }
            IsFly = true;
            _height = 250;
            _speed = 50;
            OnDataChanged();
            string message = "";
            message += String.Format("Самолет успешно взлетел{0}", Environment.NewLine);
            message += String.Format("Текущая высота равна {0} м{2} Текущая скорость равна {1} км//ч{2}", _height, _speed, Environment.NewLine);
            foreach (var item in _dispatchers)
            {
                message += String.Format("Диспетчер - {0}: рекомендуемая высота {1} м{2}", item.Name, item.Hp, Environment.NewLine);
            }
            throw new Exception(message);
    
        }
        public void ChangeDataFly(ConsoleKeyInfo keyInfo)
        {
            if(IsFly)
            {
                if ((keyInfo.Modifiers & ConsoleModifiers.Shift) != 0)
                {
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow:
                            _height += 500;
                            OnDataChanged();
                            break;
                        case ConsoleKey.DownArrow:
                            _height -= 500;
                            OnDataChanged();
                            break;
                        case ConsoleKey.LeftArrow:
                            _speed -= 150;
                            OnDataChanged();
                            break;
                        case ConsoleKey.RightArrow:
                            _speed += 150;
                            OnDataChanged();
                            break;
                    }
                }
                else
                {
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow:
                            _height += 250;
                            OnDataChanged();
                            break;
                        case ConsoleKey.DownArrow:
                            _height -= 250;
                            OnDataChanged();
                            break;
                        case ConsoleKey.LeftArrow:
                            _speed -= 50;
                            OnDataChanged();
                            break;
                        case ConsoleKey.RightArrow:
                            _speed += 50;
                            OnDataChanged();
                            break;
                    }

                }
                string message = "";
                message += String.Format("Текущая высота равна {0} м{2} Текущая скорость равна {1} км//ч{2}", _height, _speed, Environment.NewLine);
                foreach (var item in _dispatchers)
                {
                    message += String.Format("Диспетчер - {0}: рекомендуемая высотв {1} м{2}", item.Name, item.Hp, Environment.NewLine);
                }
                throw new Exception(message);
            }
            else
            {
                throw new Exception("Для изменения скорости или высоты сначала нужно взлететь");
            }
            
        }

        public void Landing()
        {
            if ((_speed > 50) || (_height >250))
            {
                throw new Exception("Посадка не возможна");
            }
            _speed = 0;
            _height = 0;
            IsFly = false;
            foreach (var item in _dispatchers)
            {
                _penalPoints += item.PenalPoints;
            }
            string message;
            message = String.Format("Самолет успешно приземлился {0}Вы набрали {1} штрафных очков {0}", Environment.NewLine, _penalPoints);
            if (!IsMaxSpedReaching || _penalPoints>=1000)
            {
                message += "Экзамен не сдан";
            }
            else
            {
                message += "Экзамен сдан";
            }
            throw new СollapseException(message);
        }
    }

}
