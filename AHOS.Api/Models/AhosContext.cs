using System;
using System.Collections.Generic;
using AHOS.Api.Models.Common;
using AHOS.Api.Models.Patient;
using Microsoft.EntityFrameworkCore;

namespace AHOS.Api.Models;

public partial class AhosContext : DbContext
{
    //public AhosContext()
    //{
    //}

    public AhosContext(DbContextOptions<AhosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CitizenApplication> CitizenApplications { get; set; }

    public virtual DbSet<CitizenApplicationService> CitizenApplicationServices { get; set; }

    public virtual DbSet<CitizenPatient> CitizenPatients { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<FamilyDoctor> FamilyDoctors { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<Nationality> Nationalities { get; set; }

    public virtual DbSet<NonCitizenPatient> NonCitizenPatients { get; set; }

    public virtual DbSet<NoncitizenPatientType> NoncitizenPatientTypes { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    => optionsBuilder.UseNpgsql("Host=localhost;Database=AHOS;Username=postgres;Password=polat2020");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {


        modelBuilder.Entity<CitizenApplication>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("CitizenApplication_pkey");

            entity.ToTable("CitizenApplication", "Patient");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<CitizenApplicationService>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("CitizenApplicationService_pkey");

            entity.ToTable("CitizenApplicationService", "Patient");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.CitizenApplication).WithMany(p => p.CitizenApplicationServices)
                .HasForeignKey(d => d.CitizenApplicationId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CitizenApplicationService_CitizenApplicationId");

            entity.HasOne(d => d.Service).WithMany(p => p.CitizenApplicationServices)
                .HasForeignKey(d => d.ServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CitizenApplicationService_ServiceId");
        });

        modelBuilder.Entity<CitizenPatient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("CitizenPatient_pkey");

            entity.ToTable("CitizenPatient", "Patient");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Active).HasColumnType("bit(1)");
            entity.Property(e => e.Deceased).HasColumnType("bit(1)");

            entity.HasOne(d => d.Gender).WithMany(p => p.CitizenPatients)
                .HasForeignKey(d => d.GenderId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Patient_Gender");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("City_pkey");

            entity.ToTable("City", "Common");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<FamilyDoctor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("FamilyDoctor_pkey");

            entity.ToTable("FamilyDoctor");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Gender_pkey");

            entity.ToTable("Gender", "Common");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Nationality>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Nationality_pkey");

            entity.ToTable("Nationality", "Common");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<NonCitizenPatient>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("NonCitizenPatient_pkey");

            entity.ToTable("NonCitizenPatient", "Patient");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Active).HasColumnType("bit(1)");
            entity.Property(e => e.Deceased).HasColumnType("bit(1)");
            entity.Property(e => e.PassportNumberVerified).HasColumnType("bit(1)");

            entity.HasOne(d => d.NoncitizenPatientType).WithMany(p => p.NonCitizenPatients)
                .HasForeignKey(d => d.NoncitizenPatientTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Patient_NoncitizenPatientType");
        });

        modelBuilder.Entity<NoncitizenPatientType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("NoncitizenPatientType_pkey");

            entity.ToTable("NoncitizenPatientType", "Common");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Service_pkey");

            entity.ToTable("Service", "Common");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
