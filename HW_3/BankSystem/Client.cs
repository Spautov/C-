using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Client
    {
        private const int _countAccounts = 2;
        private bool _isActivReservAccount;
        private string _firstName;
        private string _lastName;
        private string _login;
        private string _password;
        private int _passportNumber;
        private Account[] _accounts;


        public Account ReservAccount
        {
            get
            {
                return _accounts[1];
            }
            private set { }
        }
        public Account SettlementAccount
        {
            get
            {
                return _accounts[0];
            }
            private set { }
        }

        private void СheckСurrentAccount(int num)
        {
            if (num < 0 || num > 1)
            {
                throw new Exception("Выбран неверный счет");
            }
            if (num == 1 && (!_isActivReservAccount))
            {
                throw new Exception("Резервный счет не активирован");
            }
        }

        public void Recharge(double summ, int num)
        {
            СheckСurrentAccount(num);
            _accounts[num].Recharge(summ);
        }

        public double ReceiveMoney(double summ, int num)
        {
            СheckСurrentAccount(num);
            return _accounts[num].ReceiveMoney(summ);
        }

        public double SeeBalance(int num)
        {
            СheckСurrentAccount(num);
            return _accounts[num].Balance;
        }


        public void ActivateReseveAccount()
        {
            if (!_isActivReservAccount)
            {
                _isActivReservAccount = true;
            }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public int PassportNumber
        {
            get { return _passportNumber; }
            set { _passportNumber = value; }
        }


        public string Login
        {
            get { return _login; }
            set { _login = value; }
        }

        public int Count_accounts
        {
            get { return _countAccounts; }
            private set { }
        }

        public Client()
        {
            _firstName = "";
            _lastName = "";
            _login = "";
            _password = "";
            _isActivReservAccount = false;
            _accounts = new Account[_countAccounts];
            for (int i = 0; i< _countAccounts; ++i)
            {
                _accounts[i] = new Account();
            }

        }



    }
}
