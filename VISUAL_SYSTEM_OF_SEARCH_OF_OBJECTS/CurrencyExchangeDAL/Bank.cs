using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeDAL
{
    public class Bank
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        //public int? CurrencyExchangeInfoId { get; set; }
        //[ForeignKey("CurrencyExchangeInfoId")]
        public virtual CurrencyExchangeInfo CurrencyExchangeInfo { get; set; } //информация о курсах валют
        public virtual ICollection<PointCurrencyExchange> PointCurrencyExchanges { get; set; }

        public Bank()
        {
            PointCurrencyExchanges = new List<PointCurrencyExchange>();
        }

        public override string ToString()
        {
            return Name;
        }

        public void AddPointCurrEx(PointCurrencyExchange PointCurr)
        {
            if (PointCurrencyExchanges == null)
            {
                PointCurrencyExchanges = new List<PointCurrencyExchange>();
            }
            PointCurrencyExchanges.Add(PointCurr);
        }

       
    }
}
