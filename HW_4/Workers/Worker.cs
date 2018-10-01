using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingPart;

namespace Workers
{
    public class Worker: IWorker
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            private set { }
        }

        public Worker(string name)
        {
            _name = name;
        }

        public void Work(House hous)
        {
            string strOut;
            for (int i = 0; i < hous.CountPart; i++)
            {
                if (hous.Part[i].Ready < 100)
                {
                    hous.Part[i].Build();
                    strOut = String.Format("Я ,{0}, строю {1}, готовность - {2}%",
                        _name, hous.Part[i].Name, hous.Part[i].Ready);
                    Console.WriteLine(strOut);
                    return;
                }
            }
        }
    }
}
