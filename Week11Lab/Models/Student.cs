using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week11Lab.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string FirstName { get; set; }
        public DateTime EnrollmentDate { get; set; }

    }
}