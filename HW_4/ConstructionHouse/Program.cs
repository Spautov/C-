using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingPart;
using Workers;

namespace ConstructionHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            House hous = new House();
            Team buildTeam = new Team();
            buildTeam.Work(hous);
        }
    }
}
