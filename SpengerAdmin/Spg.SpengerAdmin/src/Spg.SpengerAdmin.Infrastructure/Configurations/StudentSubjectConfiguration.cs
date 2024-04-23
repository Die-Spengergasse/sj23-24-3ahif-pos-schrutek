using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spg.SpengerAdmin.DomainModel.Model;

namespace Spg.SpengerAdmin.Infrastructure.Configurations
{
    public class StudentSubjectConfiguration : IEntityTypeConfiguration<StudentSubject>
    {
        public void Configure(EntityTypeBuilder<StudentSubject> modelBuilder)
        {
            modelBuilder
                .HasKey(s => new { s.StudentId, s.SubjectId });
        }
    }
}
