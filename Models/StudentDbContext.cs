using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ajax1.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext() : base("StudentContext")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}