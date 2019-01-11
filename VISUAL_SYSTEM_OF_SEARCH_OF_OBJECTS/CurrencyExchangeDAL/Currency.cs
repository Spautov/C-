using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeDAL
{
    public class Currency
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Sell { get; set; }
        public double Buy { get; set; }
        public virtual CurrencyExchangeInfo CurrencyExchangeInfo { get; set; }

    }
}
