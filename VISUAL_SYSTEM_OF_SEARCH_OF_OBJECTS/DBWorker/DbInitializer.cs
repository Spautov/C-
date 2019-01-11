using CurrencyExchangeDAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkWithXML;

namespace DBWorker
{
    public class DbInitializer : DropCreateDatabaseIfModelChanges<PointsCurExchDbContext>
    {
        protected override void Seed(PointsCurExchDbContext context)
        {
            base.Seed(context);
            WorkerXML XMLWorker = new WorkerXML();
            List<PointCurrencyExchange> lstCurrPoint = XMLWorker.GetPointsCurrencyExchange();
            context.PointsCurExchanges.AddRange(lstCurrPoint);
            context.SaveChanges();
        }
    }
}
