using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingPart
{
    public class House
    {
        private BasePart[] _part;
        private int _countPart;
        //private int _ready;
        public House()
        {
            //_ready = 0;
            _countPart = 11;
            _part = new BasePart[_countPart];
            string str;
            _part[0] = new Basement("Фундамент");
            for (int i = 1; i <= 4; i++)
            {
                str = String.Format("Стена {0}", i);
                _part[i] = new Wall(str);
            }
            _part[5] = new Door("Дверь");
            for (int i = 6; i <= 9; i++)
            {
                str = String.Format("Окно {0}", i-5);
                _part[i] = new Window(str);
            }
            _part[10] = new Roof("Крыша");
        }

        public BasePart[] Part
        {
            get { return _part; }
            private set { }
        }

        public int CountPart
        {
            get { return _countPart; }
            private set { }
        }

        public int Ready
        {
            get
            {
                int ready = 0;

                for (int i = 0; i < _countPart; i++)
                {
                    ready += _part[i].Ready;
                }
                return ready / 11;
            }
            private set { }
        }
    }
}
