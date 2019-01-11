using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeDAL
{
    public class CurrencyExchangeInfo
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        [InverseProperty("CurrencyExchangeInfo")]
        public virtual ICollection<Currency> Currencys { get; set; }
        //public int? BankId;
        //[ForeignKey("BankId")]
        //public virtual Bank Bank { get; set; }

        public CurrencyExchangeInfo()
        {
            Currencys = new List<Currency>();
            Date = new DateTime(1980,1,1);
        }

        public void Add(Currency curr)
        {
            if (Currencys == null)
            {
                Currencys = new List<Currency>();
            }
            Currencys.Add(curr);
        }

    }
}
