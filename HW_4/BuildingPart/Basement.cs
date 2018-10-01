using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingPart
{
    public class Basement: BasePart, IPart
    {
        public Basement(string name) : base(name, 5)  {     }
    }
}
