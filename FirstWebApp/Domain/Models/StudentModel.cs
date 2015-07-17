using System;

namespace Domain.Models
{
    public class StudentModel : BaseDomainModel
    {
        public int StudentId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public DateTime EnrollmentDate { get; set; }
    }
}
