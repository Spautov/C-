using System;
using BestOil.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil.Repository
{
    public class AZSRepository
    {
        public List<FuelInfo> GetFuelInfo()
        {
            return new List<FuelInfo>()
            {
                new FuelInfo(){Name="АИ-92", Price = 1.34, IsWinter = true, OctanNumber=92},
                new FuelInfo(){Name="АИ-95", Price = 1.45, IsWinter = true, OctanNumber=95},
                new FuelInfo(){Name="АИ-98", Price = 1.55, IsWinter = true, OctanNumber=98}
            };
        }
    }
}
