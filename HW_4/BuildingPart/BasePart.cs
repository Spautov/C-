using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingPart
{
    public class BasePart: IPart
    {
        protected int _ready;
        protected string _name;
        protected int _step;

        public BasePart(string name, int step)
        {
            _name = name;
            _ready = 0;
            _step = step;
        }

        public int Ready
        {
            get { return _ready; }
        }
        public void Build()
        {

            if (_ready <= 100 - _step)
            {
                _ready += _step;
            }
            else
            {
                _ready = 100;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }
    }
}
