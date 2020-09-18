﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Codefirst_Web_Application.Models
{
    public class Course
    {
        public int CourseID { get; set; }

        public string Title { get; set; }
        public int Creadits { get; set; }

        public virtual ICollection<Enrollment> Enrollments {get;set;}
    }
}