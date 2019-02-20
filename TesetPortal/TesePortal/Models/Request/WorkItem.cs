using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesePortal.Models.Request
{
    public class WorkItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<WorkItemNode> WorkItemNodes { get; set; }

        public WorkItem()
        {
            WorkItemNodes = new List<WorkItemNode>();
        }
    }
}