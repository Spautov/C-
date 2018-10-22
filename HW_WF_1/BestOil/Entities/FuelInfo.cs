using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestOil.Entities
{
    public class FuelInfo
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int OctanNumber { get; set; }
        public bool IsWinter { get; set; }

        public override string ToString()
        {
            return String.Format("{0} - {1:C}", Name, Price);
        }
    }
}
