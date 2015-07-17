using System.Collections.Generic;

namespace Domain.Models
{
    public class Course : BaseDomainModel
    {
        public int CourseId { get; set; }

        public string Title { get; set; }

        public int Credits { get; set; }

        public IList<Enrollment> Enrollments { get; set; }
    }
}
