using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace brendanLowe_MIS4200.Models
{
    public class Schedule
    {
        public int scheduleID { get; set; }
        public int numClasses { get; set; }
        public int tuitionCost { get; set; }
        public virtual Course course { get; set; }
        public virtual Instructor instructor { get; set; }
    }
}