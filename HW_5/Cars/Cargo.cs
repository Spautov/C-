using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Cargo : BaseCar
    {
        private int _loadingCapacity;
        public Cargo(string model, string color, int maxSpeed, int loadingCapacity) : base(model, color, maxSpeed, 7)
        {
            if (loadingCapacity < 3)
            {
                _loadingCapacity = 3;
            }
            if (loadingCapacity > 16)
            {
                _loadingCapacity = 16;
            }
            else
            {
                _loadingCapacity = loadingCapacity;
            }
        }

        public int LoadingCapacity
        {
            get { return _loadingCapacity; }
            private set { }
        }

        public override void ComeForStart()
        {
            Console.WriteLine("{0} на старте, др-р-др-ррррррррр", _model);
        }

        protected override void Drive()
        {
            Random rnd = new Random();
            int speed = rnd.Next(_maxSpeed / 10);
            _passableWay += speed;
            Console.WriteLine("{0}: моя скорость - {1} км/ч, я проехал {2} км. Др-р-др-ррррррррр", _model, speed, _passableWay);
        }

    }
}
