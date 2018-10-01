using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildingPart;

namespace Workers
{
    interface IWorker
    {
        void Work(House hous);
    }
}
