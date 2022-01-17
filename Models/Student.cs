using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ajax1.Models
{
    public class Student
    {
        [Key]
        public int studentID { get; set; }
        public string studentName { get; set; }

        public string studentAddress { get; set; }
    }
}