using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace brendanLowe_MIS4200.Models
{
    public class Instructor

    {
        [Key] 
        public int instructorID { get; set; }
        public int numClasses { get; set; }
        public decimal salary { get; set; }
        public int studentID { get; set; }
        public int courseID { get; set; }
        public ICollection<Schedule> schedule { get; set; }
    }
}