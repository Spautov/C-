using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{

    public class Dispatcher
    {
        private string _name;
        private int _n;
        private int _Hp;
        private int _penalPoints;

        public Dispatcher(string name)
        {
            _name = name;
            Random random = new Random();
            _n = random.Next(-200, 201);
        }

        public int Hp
        {
            get { return _Hp; }
            private set { }
        }

        public string Name
        {
            get { return _name; }
            private set { }
        }

        public int N
        {
            get { return _n; }
            private set { }
        }
        public int PenalPoints
        {
            get { return _penalPoints; }
            private set { }
        }
        public void EventProcessing(Object sender, EventArgs e)
        {
            PlaneEventArgs eventArgs = (PlaneEventArgs)e;
            int sendSpeed = eventArgs.speed;
            int sedhHight = eventArgs.height;
            if (sendSpeed == 0 || sedhHight == 0)
            {
                throw new СollapseException(String.Format("Текущая скорость {1} км//ч{0}Текущая высота {2} м{0}Самолет разбился{0}", Environment.NewLine, sendSpeed, sedhHight));
            }
            if (sendSpeed >= 50)
            {
                _Hp = 7 * sendSpeed - _n;
                if (Math.Abs(_Hp - sedhHight) >= 300 && Math.Abs(_Hp - sedhHight) < 600)
                {
                    _penalPoints += 25;
                }
                if (Math.Abs(_Hp - sedhHight) >= 600 && Math.Abs(_Hp - sedhHight) < 1000)
                {
                    _penalPoints += 50;
                }
                if (sendSpeed > Plane.MaxSpeed)
                {
                    _penalPoints += 100;
                    if (_penalPoints >= 1000)
                    {
                        throw new СollapseException("Непригоден к полетам");
                    }
                    throw new Exception("Снизьте скорость. Вы превысили максипальнодопустимую.");
                }
                if (Math.Abs(_Hp - sedhHight) >= 1000)
                {
                    throw new СollapseException(String.Format("Текущая скорость {1} км//ч{0}Текущая высота {2} м{0}Самолет разбился{0}",Environment.NewLine, sendSpeed, sedhHight));
                }
                if (_penalPoints >= 1000)
                {
                    throw new СollapseException("Непригоден к полетам");
                }
              
            }
            
        }

    }
}
