using Domain.Models;

namespace Domain.Configurations
{
    public class CourseConfiguration : BaseConfiguration<Course>
    {
        public CourseConfiguration()
        {
            ToTable("Courses");

            HasKey(k => k.CourseId);

            HasMany(e => e.Enrollments)
                .WithRequired(e => e.Course)
                .HasForeignKey(e => e.CourseId)
                .WillCascadeOnDelete(false);
        }
    }
}
