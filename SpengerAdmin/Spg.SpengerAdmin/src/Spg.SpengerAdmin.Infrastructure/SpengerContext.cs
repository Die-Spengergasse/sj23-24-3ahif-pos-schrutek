using Microsoft.EntityFrameworkCore;
using Spg.SpengerAdmin.DomainModel.Model;

namespace Spg.SpengerAdmin.Infrastructure
{
    // 1. OR-Mapper installieren, OK
    // 1.1. Basisklasse hinzufügen, OK
    // 2. DB-Sets (Tabellen <--> Entities), OK
    // 3. Konstruktoren, OK
    // 4. Konfiguration (wo (ConnectionString) ist meine DB und was (Provider/Driver) ist meine DB), OK
    // 5. Fluent API

    // Inspirations:
    // * Inheritance Mapping:
    // https://learn.microsoft.com/en-us/ef/core/modeling/inheritance
    // * N + 1 - Problem:
    // https://www.thinktecture.com/entity-framework-core/entity-framework-core7-n1-queries-problem/
    // https://medium.com/@pawel.gerr/entity-framework-core-2-0-performance-beware-of-n-1-queries-be4598701871

    public class SpengerContext : DbContext
    {
        public DbSet<ClassRoom> ClassRooms => Set<ClassRoom>();
        public DbSet<MeetingRoom> MeetingRooms => Set<MeetingRoom>();
        public DbSet<Student> Students => Set<Student>();
        public DbSet<Teacher> Teachers => Set<Teacher>();
        public DbSet<Subject> Subjects => Set<Subject>();
        public DbSet<Exam> Exams => Set<Exam>();
        public DbSet<StudentSubject> StudentSubjects => Set<StudentSubject>();

        public SpengerContext()
            : base()
        { }
        public SpengerContext(DbContextOptions options)
            : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        /// <summary>
        /// Fluent-API
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder
            //    .Entity<ClassRoom>()
            //    .HasKey(c => c.Id)
            //    .HasName(nameof(ClassRoom))
            //    .IsClustered();

            modelBuilder
                .Entity<Student>()
                .OwnsOne(p => p.Address);

            modelBuilder
                .Entity<Teacher>()
                .OwnsOne(p => p.Address);

            //modelBuilder
            //    .Entity<Teacher>().HasKey(p => new { p.FirstName, p.LastName });

            modelBuilder.Entity<Room>()
                .HasDiscriminator<string>("RoomType");
        }
    }
}
