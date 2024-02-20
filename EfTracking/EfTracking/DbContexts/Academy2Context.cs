using System;
using System.Collections.Generic;
using EfTracking.Models;
using Microsoft.EntityFrameworkCore;

namespace EfTracking.DbContexts;

public partial class Academy2Context : DbContext
{
    public Academy2Context()
    {
    }

    public Academy2Context(DbContextOptions<Academy2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Faculty> Faculties { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<GroupsDatum> GroupsData { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudyPlan> StudyPlans { get; set; }

    public virtual DbSet<Teacher> Teachers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder
        //.UseLazyLoadingProxies()
        .UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Academy2;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3214EC0715596A1E");

            entity.Property(e => e.Salary).HasColumnType("smallmoney");
        });

        modelBuilder.Entity<Faculty>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Facultie__3214EC075AE40044");

            entity.Property(e => e.Name).HasMaxLength(30);
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Groups__3214EC0720034440");

            entity.Property(e => e.Name).HasMaxLength(30);

            entity.HasOne(d => d.Faculty).WithMany(p => p.Groups)
                .HasForeignKey(d => d.FacultyId)
                .HasConstraintName("FK__Groups__FacultyI__35BCFE0A");
        });

        modelBuilder.Entity<GroupsDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__GroupsDa__3214EC079227E67B");

            entity.HasOne(d => d.Group).WithMany(p => p.GroupsData)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK__GroupsDat__Group__398D8EEE");

            entity.HasOne(d => d.Student).WithMany(p => p.GroupsData)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__GroupsDat__Stude__38996AB5");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__People__3214EC07E8D6567A");

            entity.HasIndex(e => e.Email, "UQ__People__A9D105347C718518").IsUnique();

            entity.Property(e => e.Email).HasMaxLength(30);
            entity.Property(e => e.Name).HasMaxLength(30);
            entity.Property(e => e.Surname).HasMaxLength(30);
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Students__3214EC078C33DC58");

            entity.Property(e => e.Gpa).HasColumnName("GPA");

            entity.HasOne(d => d.Person).WithMany(p => p.Students)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("FK__Students__Person__2E1BDC42");
        });

        modelBuilder.Entity<StudyPlan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StudyPla__3214EC070B00A490");

            entity.HasOne(d => d.Group).WithMany(p => p.StudyPlans)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK__StudyPlan__Group__3D5E1FD2");

            entity.HasOne(d => d.Teacher).WithMany(p => p.StudyPlans)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("FK__StudyPlan__Teach__3C69FB99");
        });

        modelBuilder.Entity<Teacher>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Teachers__3214EC07CF63E113");

            entity.HasOne(d => d.Employee).WithMany(p => p.Teachers)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK__Teachers__Employ__31EC6D26");

            entity.HasOne(d => d.Person).WithMany(p => p.Teachers)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("FK__Teachers__Person__30F848ED");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
