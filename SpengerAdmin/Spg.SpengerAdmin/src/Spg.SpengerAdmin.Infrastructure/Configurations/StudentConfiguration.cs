using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spg.SpengerAdmin.DomainModel.Model;
using System.Reflection.Emit;

namespace Spg.SpengerAdmin.Infrastructure.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder
                .OwnsOne(s => s.Address);
        }
    }
}
