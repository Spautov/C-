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
    public class PointsCurExchDbContext: DbContext
    {
        public PointsCurExchDbContext()
            : base("DbConnection")
        {
                
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Database.SetInitializer(new DbInitializer());
        }

        public DbSet<PointCurrencyExchange> PointsCurExchanges { get; set; }
       
        public void RefreshCurses()
        {
            try
            {
                WorkerXML workerXML = new WorkerXML();
                List<Bank> lstBanks = workerXML.GetBanks();
                Bank findBank = null;
                foreach (var pce in PointsCurExchanges)
                {
                    findBank = lstBanks.Find(b => b.Name.Equals(pce.Bank.Name));
                    if (findBank != null)
                    {
                        pce.Bank = findBank;
                    }

                }
                SaveChanges();
            }
            catch (Exception)
            {
                throw new Exception("Неудалось обновить данные из открытых источников");
            }
            
        }

    }
}
