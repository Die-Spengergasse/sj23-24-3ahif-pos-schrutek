using Microsoft.EntityFrameworkCore;
using Spg.SpengerAdmin.DomainModel.Model;
using Spg.SpengerAdmin.Infrastructure.Configurations;
using System.Reflection;

namespace Spg.SpengerAdmin.Infrastructure
{
    // 1. OR-Mapper installieren, OK
    // 1.1. Basisklasse hinzufügen, OK
    // 2. DB-Sets (Tabellen <--> Entities), OK
    // 3. Konstruktoren, OK
    // 4. Konfiguration (wo (ConnectionString) ist meine DB und was (Provider/Driver) ist meine DB), OK
    // 5. Fluent API

    // Inspirations:
    // * N + 1 - Problem:
    // https://www.thinktecture.com/entity-framework-core/entity-framework-core7-n1-queries-problem/
    // https://medium.com/@pawel.gerr/entity-framework-core-2-0-performance-beware-of-n-1-queries-be4598701871
    //
    // * 1..n mapping:
    // https://learn.microsoft.com/en-us/ef/core/modeling/relationships/one-to-many
    // * n..n mapping:
    // https://learn.microsoft.com/en-us/ef/core/modeling/relationships/many-to-many
    // * inheritance mapping:
    // https://learn.microsoft.com/en-us/ef/core/modeling/inheritance
    // * Value Objects
    // https://learn.microsoft.com/en-us/ef/core/modeling/owned-entities#collections-of-owned-types

    public class SpengerContext : DbContext
    {
        private string myField;


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
        /// https://learn.microsoft.com/en-us/ef/core/modeling/data-seeding
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new SubjectConfiguration());
            modelBuilder.ApplyConfiguration(new StudentSubjectConfiguration());
            modelBuilder.ApplyConfiguration(new RoomConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
        }
    }
}
