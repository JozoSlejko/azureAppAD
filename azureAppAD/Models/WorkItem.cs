using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace azureAppAD.Models
{
    public class WorkItem
    {
        [Key]
        public int ItemID { get; set; }
        public string AssignedToID { get; set; }
        public string AssignedToName { get; set; }
        public string Description { get; set; }
        public WorkItemStatus Status { get; set; }
    }

    public enum WorkItemStatus
    {
        Open,
        Investigating,
        Resolved,
        Closed
    }
    }