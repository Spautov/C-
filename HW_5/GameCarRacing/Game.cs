using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars;

namespace GameCarRacing
{
    public class Game
    {
        private BaseCar[] _raceCars;
        private int _countCar;
        private bool _isGameOver;
        private PlaceStart placeStart;
        private StartRacing startRacing;
        public Game()
        {
            Random rnd = new Random();
            _countCar = rnd.Next(4, 10);
            _raceCars = new BaseCar[_countCar];
            int typeCar;
            string modelName;
            int maxSpeed = 0;
            for (int i = 0; i < _countCar; ++i)
            {
                typeCar = rnd.Next(4);
                switch (typeCar)
                {
                    case 0:
                        modelName = String.Format("Спортивный №{0}", i + 1);
                        maxSpeed = rnd.Next(220, 350);
                        _raceCars[i] = new SportCar(modelName, "красный", maxSpeed);
                        registEvent(_raceCars[i]);
                        break;
                    case 1:
                        modelName = String.Format("Легковой №{0}", i + 1);
                        maxSpeed = rnd.Next(180, 230);
                        Cars.TypeCar type = (Cars.TypeCar)rnd.Next(4);
                        _raceCars[i] = new Car(modelName, "серый", maxSpeed, type);
                        registEvent(_raceCars[i]);
                        break;
                    case 2:
                        modelName = String.Format("Автобус №{0}", i + 1);
                        maxSpeed = rnd.Next(120, 150);
                        int countPass = rnd.Next(8, 33);
                        _raceCars[i] = new Bus(modelName, "желтый", maxSpeed, countPass);
                        registEvent(_raceCars[i]);
                        break;
                    case 3:
                        modelName = String.Format("Грузовой №{0}", i + 1);
                        maxSpeed = rnd.Next(100, 160);
                        int load = rnd.Next(3, 17);
                        _raceCars[i] = new Cargo(modelName, "синий", maxSpeed, load);
                        registEvent(_raceCars[i]);
                        break;
                }
            }

            for (int i = 0; i < _countCar; i++)
            {
                for (int j = 0; j < _countCar; j++)
                {
                    if (i != j)
                    {
                        _raceCars[i].StopRacing += _raceCars[j].EndGeme;
                    }
                }
            }
        }

        private delegate void PlaceStart();
        private delegate void StartRacing();

        public void EndGeme(Object sender, EventArgs e)
        {
            BaseCar Winner = (BaseCar)sender;
            Console.WriteLine("Победителем стал: {0} ", Winner.Model);
            _isGameOver = true;
        }

        public void OnStartRacing()
        {
            placeStart();
            while (!_isGameOver)
            {
                startRacing();
            }
        }

        private void registEvent(BaseCar car)
        {
            placeStart += car.ComeForStart;
            startRacing += car.Racing;
            car.StopRacing += EndGeme;
        }
    }
}
