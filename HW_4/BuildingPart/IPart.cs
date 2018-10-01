using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingPart
{
    interface IPart
    {
        void Build();
        int Ready { get; }
        string Name { get; }
    }
}
