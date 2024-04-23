using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spg.SpengerAdmin.DomainModel.Model;
using System.Reflection.Emit;

namespace Spg.SpengerAdmin.Infrastructure.Configurations
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder
                .OwnsOne(t => t.Address);
        }
    }
}
