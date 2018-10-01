using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Bus : BaseCar
    {
        private int _countPassanger;
        public Bus(string model, string color, int maxSpeed, int countPassanger) : base(model, color, maxSpeed, 8)
        {
            if (countPassanger < 8 )
            {
                _countPassanger = 8;
            }
            if (countPassanger > 32)
            {
                _countPassanger = 32;
            }
            else
            {
                _countPassanger = countPassanger;
            }
        }

        public int CountPassanger
        {
            get { return _countPassanger; }
            private set { }
        }

        public override void ComeForStart()
        {
            Console.WriteLine("{0} на старте, У-У-УУУУУУУУ", _model);
        }

        protected override void Drive()
        {
            Random rnd = new Random();
            int speed = rnd.Next(_maxSpeed / 10);
            _passableWay += speed;
            Console.WriteLine("{0}: моя скорость - {1} км/ч, я проехал {2} км. У-У-УУУУУУУУ", _model, speed, _passableWay);
        }

    }

}
