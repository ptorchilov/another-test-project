using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Student : BaseDomainModel
    {
        public int StudentId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public IList<Enrollment> Enrollments { get; set; }
    }
}
