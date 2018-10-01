using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class Bank
    {
        private const int _maxCountClients = 10;
        private int _countClients;
        private int _currentClient;
        public Client[] clients;


       
        public Bank()
        {
            _countClients = 0;
            clients = new Client[_maxCountClients];
            for (int i = 0; i< _maxCountClients; ++i)
            {
                clients[i] = new Client();
            }
            
        }

        public int CountClient
        {
            get { return _countClients; }
            private set { }
        }

        public void AddClient(string firstName, string lastName, string login, string password, int passportNumber)
        {
            if (_countClients == _maxCountClients)
            {
                throw new Exception("Отсутствует возможность добавить клиента");
            }
            clients[_countClients].FirstName = firstName;
            clients[_countClients].LastName = lastName;
            clients[_countClients].Login = login;
            clients[_countClients].Password = password;
            clients[_countClients].PassportNumber = passportNumber;
            _countClients++;
        }

        public int LogIn(string login, string password)
        {
            for (int i=0; i< _countClients; ++i)
            {
                if (clients[i].Login == login && clients[i].Password == password)
                {
                    return i;
                }
                
            }
            return -1;
        }
    }
}