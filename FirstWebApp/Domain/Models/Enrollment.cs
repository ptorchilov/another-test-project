﻿using System;

namespace Domain.Models
{
    public class Enrollment : BaseDomainModel
    {
        public int EnrollmentId { get; set; }

        public int CourseId { get; set; }

        public int StudentId { get; set; }

        public DateTime Grade { get; set; }

        public Course Course { get; set; }

        public Student Student { get; set; }
    }
}
