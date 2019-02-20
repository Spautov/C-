using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesePortal.Models.Request
{
    public class WorkItemNode
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual WorkItem WorkItem { get; set; }
    }
}