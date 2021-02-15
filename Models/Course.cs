using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace brendanLowe_MIS4200.Models
{
    public class Course
    {
        public int courseID { get; set; }
        public string description { get; set; }
        public DateTime classTime { get; set; }
        public int studentID { get; set; }
        public virtual student student { get; set; }
        public ICollection<Schedule> schedule { get; set; }
    }
}