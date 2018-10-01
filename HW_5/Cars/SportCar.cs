using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class SportCar : BaseCar
    {
        public SportCar(string model, string color, int maxSpeed): base(model, color, maxSpeed, 15) 
        {
            
        }

        public override void ComeForStart()
        {
            Console.WriteLine("{0} на старте, жжжж-ж-ж-ж-жжж", _model);
        }

        protected override void Drive()
        {
            Random rnd = new Random();
            int speed = rnd.Next(_maxSpeed / 10);
            _passableWay += speed;
            Console.WriteLine("{0}: моя скорость - {1} км/ч, я проехал {2} км. Жжжж-ж-ж-ж-жжж", _model, speed, _passableWay);
        }

    }
}
