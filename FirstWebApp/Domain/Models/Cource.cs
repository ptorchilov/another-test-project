namespace Domain.Models
{
    public class Cource : BaseDomainModel
    {
        public int CourseId { get; set; }

        public string Title { get; set; }

        public int Credits { get; set; }
    }
}
