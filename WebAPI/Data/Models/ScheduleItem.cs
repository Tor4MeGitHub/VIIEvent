using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Data.Models
{
    // In each item should be implemented Timer??
    public class ScheduleItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}