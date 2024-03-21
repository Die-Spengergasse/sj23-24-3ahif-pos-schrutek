using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Spg.SpengerAdmin.Infrastructure.Models;

public partial class SpengerAdminContext : DbContext
{
    public SpengerAdminContext()
    {
    }

    public SpengerAdminContext(DbContextOptions<SpengerAdminContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ClassRoom> ClassRooms { get; set; }

    public virtual DbSet<Exam> Exams { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<Subject> Subjects { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("DataSource=C:\\HTL\\Unterricht\\SJ2324\\3AHIF\\sj23-24-3ahif-pos-schrutek\\SpengerAdmin\\Spg.SpengerAdmin\\test\\Spg.SpengerAdmin.DomainModelTest\\bin\\Debug\\net8.0\\SpengerAdmin.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Exam>(entity =>
        {
            entity.HasIndex(e => e.ClassRoomId, "IX_Exams_ClassRoomId");

            entity.HasIndex(e => e.SubjectId, "IX_Exams_SubjectId");

            entity.HasIndex(e => e.TeacherId, "IX_Exams_TeacherId");

            entity.HasOne(d => d.ClassRoom).WithMany(p => p.Exams).HasForeignKey(d => d.ClassRoomId);

            entity.HasOne(d => d.Subject).WithMany(p => p.Exams).HasForeignKey(d => d.SubjectId);

            entity.HasOne(d => d.Teacher).WithMany(p => p.Exams).HasForeignKey(d => d.TeacherId);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasIndex(e => e.ClassRoomNavigationId, "IX_Students_ClassRoomNavigationId");

            entity.Property(e => e.AddressCity).HasColumnName("Address_City");
            entity.Property(e => e.AddressHouseNumber).HasColumnName("Address_HouseNumber");
            entity.Property(e => e.AddressStreet).HasColumnName("Address_Street");
            entity.Property(e => e.AddressZipCode).HasColumnName("Address_ZipCode");

            entity.HasOne(d => d.ClassRoomNavigation).WithMany(p => p.Students).HasForeignKey(d => d.ClassRoomNavigationId);
        });

        modelBuilder.Entity<Subject>(entity =>
        {
            entity.HasIndex(e => e.StudentId, "IX_Subjects_StudentId");

            entity.HasOne(d => d.Student).WithMany(p => p.Subjects).HasForeignKey(d => d.StudentId);
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.Property(e => e.AddressCity).HasColumnName("Address_City");
            entity.Property(e => e.AddressHouseNumber).HasColumnName("Address_HouseNumber");
            entity.Property(e => e.AddressStreet).HasColumnName("Address_Street");
            entity.Property(e => e.AddressZipCode).HasColumnName("Address_ZipCode");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
