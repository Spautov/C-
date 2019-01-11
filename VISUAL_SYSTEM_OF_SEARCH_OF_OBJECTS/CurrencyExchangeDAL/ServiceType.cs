using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeDAL
{
    public class ServiceType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        //public virtual PointCurrencyExchange PointCurrencyEx { get; set; }

        public ServiceType()
        {
            //PointCurrencyEx = new PointCurrencyExchange();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
