using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingPart;
namespace Workers
{
    public class Team: IWorker
    {
        public TeamLeader teamLeader;
        public Worker[] worker;

        public Team()
        {
            teamLeader = new TeamLeader("Бригадир");
            worker = new Worker[4];
            string str;
            for (int i = 0; i<4; ++i)
            {
                str = String.Format("Рабочий {0}", i + 1);
                worker[i] = new Worker(str);
            }
        }

        public void Work(House hous)
        {
            Console.WriteLine("Мы начинаем строительсов дома!!!!");
            Console.WriteLine();
            while (hous.Ready != 100)
            {
                for (int i = 0; i < 4; i++)
                {
                    worker[i].Work(hous);
                }
                Console.WriteLine();
                teamLeader.Work(hous);
                Console.WriteLine();
            }

            Console.WriteLine("Дом построен!!!!!!!");
            Console.WriteLine();
            Console.WriteLine("       ***************");
            Console.WriteLine("      * *             *");
            Console.WriteLine("     *   *             * ");
            Console.WriteLine("    *     *             *");
            Console.WriteLine("    **********************");
            Console.WriteLine("    *  *** *    ***      *");
            Console.WriteLine("    *  * * *    * *      *");
            Console.WriteLine("    *  * * *    ***      *");
            Console.WriteLine("    *  * * *             *");
            Console.WriteLine("    ******* **************");
            Console.WriteLine("    ******* **************");
        }

    }
}
