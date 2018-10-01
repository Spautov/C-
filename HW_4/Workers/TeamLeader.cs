using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingPart;

namespace Workers
{
    public class TeamLeader: IWorker
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            private set { }
        }

        public TeamLeader(string name)
        {
            _name = name;
        }

        public void Work(House hous)
        {
            string strOut;
            Console.WriteLine("{0}, отчет о строительстве:", _name);
            for (int i = 0; i < hous.CountPart; i++)
            {
                   strOut = String.Format("{0}, готовность - {1}%",
                        hous.Part[i].Name, hous.Part[i].Ready);
                    Console.WriteLine(strOut);
            }
        }
    }
}
