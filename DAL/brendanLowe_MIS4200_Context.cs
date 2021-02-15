using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using brendanLowe_MIS4200.Models;

namespace brendanLowe_MIS4200.DAL
{
    public class brendanLowe_MIS4200_Context : DbContext 
    {
        public brendanLowe_MIS4200_Context() : base ("name=DefaultConnection")
        {

        }
        public DbSet<Course> courses  { get; set; }
        public DbSet<student> students { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<Schedule> schedules { get; set; }

    }
}