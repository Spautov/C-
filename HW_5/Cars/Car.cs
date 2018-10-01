using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Car : BaseCar
    {
        private TypeCar _type;
        public Car(string model, string color, int maxSpeed, TypeCar type = TypeCar.SEDEN) : base(model, color, maxSpeed, 10)
        {
            _type = type;
        }

        public TypeCar TypeSalon
            {
                get { return _type; }
                private set { }
            }


        public override void ComeForStart()
        {
            Console.WriteLine("{0} на старте, зум-зум-ммммммм", _model);
        }

        protected override void Drive()
        {
            Random rnd = new Random();
            int speed = rnd.Next(_maxSpeed / 10);
            _passableWay += speed;
            Console.WriteLine("{0}: моя скорость - {1} км/ч, я проехал {2} км. Зум-зум-ммммммм", _model, speed, _passableWay);
        }
    }

    public enum TypeCar
    {
        SEDEN,
        HATCHBACK,
        VARIANT,
        LIFTBACK
    }
}
