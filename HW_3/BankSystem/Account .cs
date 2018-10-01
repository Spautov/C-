using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Account
    {
        private static int _number = 0;
        private int _accountNumber;
        private double _balance;
        private float _percent;

        public double Balance
        {
            get { return _balance; }
            private set { }
        }

        public float Percent
        {
            get { return _percent; }
            set
            {
                if (value < 0.0f && value > 50.0f)
                {
                    throw new Exception("Недопустимое значение");
                }
                else
                {
                    _percent = value;
                }
            }
        }

        public int Number
        {
            get { return _accountNumber; }
            private set { }
        }
        public Account()
        {
            _accountNumber = ++_number;
            _balance = 0.0;
            _percent = 2.0f;
        }
        
        public double ReceiveMoney(double summ)
        {
            double summtWithPercent = summ * (1.0 + _percent / 100);
            if (summtWithPercent <= _balance && summ >= 0)
            {
                _balance -= summtWithPercent;
                return summ;
            }
            else if (summ < 0)
            {
                throw new Exception("Некорректная сумма");
            }
            else
            {
                throw new Exception("На счету не достаточно средств");
            }

        }
        public void Recharge(double summ)
        {
            if (summ >= 0)
            {
                _balance += summ;
            }
            else
            {
                throw new Exception("Некорректная сумма");
            }
        }
    }
}
