using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TesePortal.Models.Request
{
    public class DemandContext : DbContext
    {
        public DemandContext(): base("RequestDb") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Database.SetInitializer(new DemandDbInitializer());
        }

        public DbSet<Demand> Requests { get; set; }
        public DbSet<WorkItem> WorkItems { get; set; }
        public DbSet<WorkItemNode> WorkItemNodes { get; set; }

    }
}