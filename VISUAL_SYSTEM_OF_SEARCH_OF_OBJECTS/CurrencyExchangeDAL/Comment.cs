using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchangeDAL
{
    public class Comment
    {
        
        public int Id { get; set; }
        public string Author { get; set; }
        public DateTime Data { get; set; }
        public string Contents { get; set; }
        public virtual PointCurrencyExchange PointCurrencyEx { get; set; }

        public Comment()
        {
            Data = new DateTime(1980, 1, 1);
            //PointCurrencyEx = new PointCurrencyExchange();
        }

        public override string ToString()
        {
            string str = String.Format("Автор: {0}  {1}{2}  {1}Дата: {3}{1}", 
                Author, Environment.NewLine, 
                Contents, 
                Data.ToString("yyyy-MM-dd"));
            return str;
        }
    }
}
