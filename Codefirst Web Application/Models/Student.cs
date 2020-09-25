using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Codefirst_Web_Application.Models
{
    public class Student
    {
        public int ID { get; set; }

        public string LastName { get; set; }

        public string FistMidName { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public string Address { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}