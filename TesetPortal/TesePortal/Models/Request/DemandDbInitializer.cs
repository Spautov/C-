using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TesePortal.Models.Request
{
    // DropCreateDatabaseIfModelChanges<RequestContext>
    //DropCreateDatabaseAlways<RequestContext>
    public class DemandDbInitializer : DropCreateDatabaseIfModelChanges<DemandContext>
    {
        protected override void Seed(DemandContext context)
        {
            base.Seed(context);
            WorkItem WorkItem1 = new WorkItem() { Name = "Лущильный станок" };
            WorkItem WorkItem2 = new WorkItem() { Name = "Делительный станок" };
            WorkItem WorkItem3 = new WorkItem() { Name = "Фанерный пресс" };

            WorkItemNode WorkItemNode11 = new WorkItemNode() { Name = "Лущильный нож", WorkItem = WorkItem1 };
            WorkItemNode WorkItemNode12 = new WorkItemNode() { Name = "Стружкопылесос", WorkItem = WorkItem1 };
            WorkItemNode WorkItemNode13 = new WorkItemNode() { Name = "Двигатель привода", WorkItem = WorkItem1 };
            WorkItem1.WorkItemNodes.Add(WorkItemNode11);
            WorkItem1.WorkItemNodes.Add(WorkItemNode12);
            WorkItem1.WorkItemNodes.Add(WorkItemNode13);

            WorkItemNode WorkItemNode21 = new WorkItemNode() { Name = "Ротор", WorkItem = WorkItem2 };
            WorkItemNode WorkItemNode22 = new WorkItemNode() { Name = "Транспортер", WorkItem = WorkItem2 };
            WorkItemNode WorkItemNode23 = new WorkItemNode() { Name = "Механизм подачи", WorkItem = WorkItem2 };
            WorkItem2.WorkItemNodes.Add(WorkItemNode21);
            WorkItem2.WorkItemNodes.Add(WorkItemNode22);
            WorkItem2.WorkItemNodes.Add(WorkItemNode23);

            WorkItemNode WorkItemNode31 = new WorkItemNode() { Name = "Цилиндры", WorkItem = WorkItem3 };
            WorkItemNode WorkItemNode32 = new WorkItemNode() { Name = "Гидросистема", WorkItem = WorkItem3 };
            WorkItemNode WorkItemNode33 = new WorkItemNode() { Name = "Нагревательные плиты", WorkItem = WorkItem3 };
            WorkItem3.WorkItemNodes.Add(WorkItemNode31);
            WorkItem3.WorkItemNodes.Add(WorkItemNode32);
            WorkItem3.WorkItemNodes.Add(WorkItemNode33);
            context.WorkItems.Add(WorkItem1);
            context.WorkItems.Add(WorkItem2);
            context.WorkItems.Add(WorkItem3);
            
            context.SaveChanges();

            //начальная инициализации БД
        }
    }
}