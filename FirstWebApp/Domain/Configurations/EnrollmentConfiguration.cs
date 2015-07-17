using Domain.Models;

namespace Domain.Configurations
{
    public class EnrollmentConfiguration : BaseConfiguration<Enrollment>
    {
        public EnrollmentConfiguration()
        {
            ToTable("Enrollment");

            HasKey(k => k.EnrollmentId);

            HasOptional(e => e.Student)
                .WithMany()
                .HasForeignKey(k => k.StudentId);

            HasOptional(e => e.Course)
                .WithMany()
                .HasForeignKey(k => k.CourseId);
        }
    }
}
