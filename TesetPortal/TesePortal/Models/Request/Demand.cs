using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesePortal.Models.Request
{
    public class Demand
    {
        public int Id { get; set; }
        public string OperatorId { get; set; }
        public string TechnicianId { get; set; }
        public int WorkItemId { get; set; }
        public int WorkItemNodeId { get; set; }
        public string CommentOfTechnician { get; set; }
        public string CommentOfOperator { get; set; }
        public bool IsCritical { get; set; }
        public bool IsWaitParts { get; set; }
        public int Status { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime EndDate { get; set; }

        public Demand()
        {           
            CreationDate = new DateTime(1980, 1, 1);
            EndDate = new DateTime(1980, 1, 1);
        }
       
        //Status INT DEFAULT(0),
    }
}