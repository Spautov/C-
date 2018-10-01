using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public abstract class BaseCar
    {
        protected const int TRECLENGHT = 100;
        protected string _color;
        protected string _model;
        protected int _maxSpeed;
        protected int _acceleration;
        protected int _passableWay;
        private bool _isGameOver;

        public event EventHandler StopRacing;

        public void EndGeme(Object sender, EventArgs e)
        {
            Console.WriteLine("{0} проехал {1} км.", _model, _passableWay);
            _isGameOver = true;
        }

        protected void OnStopRaicing()
        {
            if (StopRacing != null)
            {
                StopRacing(this, EventArgs.Empty);
            }
        }
        public string Color
        {
            get { return _color; }
            private set { }
        }

        public string Model
        {
            get { return _model; }
            private set { }
        }

        public BaseCar(string model, string color, int maxSpeed, int acceleration)
        {
            _model = model;
            _color = color;
            _maxSpeed = maxSpeed;
            _acceleration = acceleration;
        }


        public int MaxSpeed
        {
            get { return _maxSpeed; }
            private set { }
        }

        public int Acceleration
        {
            get { return _acceleration; }
            private set { }
        }

        protected abstract void Drive();
        public abstract void ComeForStart();
        public void Racing()
        {
            if (!_isGameOver)
                Drive();
            if (_passableWay >= TRECLENGHT)
                OnStopRaicing();
        }
    }
}
