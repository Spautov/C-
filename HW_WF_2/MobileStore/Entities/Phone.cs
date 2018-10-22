using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.Entities
{
    [Serializable]
    public class Phone
    {
        private string _model;
        private string _os;
        private string _CPU;
        private double _price;
        private BindingList<string> _options;
        private string _imagePath;

        public Phone()
        {
            Options = new BindingList<string>();
        }

        public string Model { get { return _model; } set { _model = value; } }
        public string Os { get { return _os; } set { _os = value; } }
        public string CPU { get { return _CPU; } set { _CPU = value; } }
        public double Price { get { return _price; } set { _price = value; } }
        public string ImagePath { get { return _imagePath; } set { _imagePath = value; } }
        public BindingList<string> Options { get { return _options; } set { _options = value; } }

        public override string ToString()
        {
            return String.Format("{0}. {1}. CPU:{2}. Цена {3:N2}"
                , Model, Os, CPU, Price);
        }
    }
}
