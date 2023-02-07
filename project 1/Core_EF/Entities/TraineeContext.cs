using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Core_EF.Entities;

public partial class TraineeContext : DbContext
{
    public TraineeContext()
    {
    }

    public TraineeContext(DbContextOptions<TraineeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CompanyDetail> CompanyDetails { get; set; }

    public virtual DbSet<EducationalDetail> EducationalDetails { get; set; }

    public virtual DbSet<Skill> Skills { get; set; }

    public virtual DbSet<TraineeDetail> TraineeDetails { get; set; }

    /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=Laptop-S7D0E4KP;Database=trainee;Trusted_Connection=True;Encrypt=False;");*/

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CompanyDetail>(entity =>
        {
            entity.HasKey(e => e.TraineeId).HasName("pk_company");

            entity.Property(e => e.TraineeId).ValueGeneratedOnAdd();
            entity.Property(e => e.Company_name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Company_name");
            entity.Property(e => e.Experience)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Position)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ProjectName)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.Trainee).WithOne(p => p.CompanyDetail)
                .HasForeignKey<CompanyDetail>(d => d.TraineeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Fk_company");
        });

        modelBuilder.Entity<EducationalDetail>(entity =>
        {
            entity.HasKey(e => e.TraineeId).HasName("pk_education");

            entity.Property(e => e.TraineeId).ValueGeneratedOnAdd();
            entity.Property(e => e.Hqualification)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("HQualification");
            entity.Property(e => e.Percentage)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Stream)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.YearOfPassing)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Trainee).WithOne(p => p.EducationalDetail)
                .HasForeignKey<EducationalDetail>(d => d.TraineeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Fk_education");
        });

        modelBuilder.Entity<Skill>(entity =>
        {
            entity.HasKey(e => e.TraineeId).HasName("Pk_skill");

            entity.Property(e => e.TraineeId).ValueGeneratedOnAdd();
            entity.Property(e => e.Expertise)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Skill_name)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Skill_name");
            entity.Property(e => e.Skill_Type)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Skill_Type");

            entity.HasOne(d => d.Trainee).WithOne(p => p.Skill)
                .HasForeignKey<Skill>(d => d.TraineeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("Fk_skill");
        });

        modelBuilder.Entity<TraineeDetail>(entity =>
        {
            entity.HasKey(e => e.TraineeId).HasName("PK__TraineeD__3BA911CA3C85BA09");

            entity.Property(e => e.EmailId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FullName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
