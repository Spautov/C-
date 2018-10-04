using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airport
{
    public class СollapseException: Exception
    {
        public СollapseException(string message):base(message) {  }
    }
}
