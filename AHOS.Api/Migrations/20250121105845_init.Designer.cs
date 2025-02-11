﻿// <auto-generated />
using System;
using System.Collections;
using AHOS.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AHOS.Api.Migrations
{
    [DbContext(typeof(AhosContext))]
    [Migration("20250121105845_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AHOS.Api.Models.Common.City", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<int?>("Code")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("City_pkey");

                    b.ToTable("City", "Common");
                });

            modelBuilder.Entity("AHOS.Api.Models.Common.FamilyDoctor", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("SurName")
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("FamilyDoctor_pkey");

                    b.ToTable("FamilyDoctor", (string)null);
                });

            modelBuilder.Entity("AHOS.Api.Models.Common.Gender", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<int?>("Code")
                        .HasColumnType("integer");

                    b.Property<string>("CodeStr")
                        .HasColumnType("text");

                    b.Property<Guid?>("Key")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("Gender_pkey");

                    b.ToTable("Gender", "Common");
                });

            modelBuilder.Entity("AHOS.Api.Models.Common.Nationality", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<int?>("Code")
                        .HasColumnType("integer");

                    b.Property<string>("CodeStr")
                        .HasColumnType("text");

                    b.Property<Guid?>("Key")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("Nationality_pkey");

                    b.ToTable("Nationality", "Common");
                });

            modelBuilder.Entity("AHOS.Api.Models.Common.NoncitizenPatientType", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<int?>("Code")
                        .HasColumnType("integer");

                    b.Property<string>("CodeStr")
                        .HasColumnType("text");

                    b.Property<Guid?>("Key")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("NoncitizenPatientType_pkey");

                    b.ToTable("NoncitizenPatientType", "Common");
                });

            modelBuilder.Entity("AHOS.Api.Models.Common.Service", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<int?>("Code")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double?>("Price")
                        .HasColumnType("double precision");

                    b.HasKey("Id")
                        .HasName("Service_pkey");

                    b.ToTable("Service", "Common");
                });

            modelBuilder.Entity("AHOS.Api.Models.Patient.CitizenApplication", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<short>("ApplicationStatus")
                        .HasColumnType("smallint");

                    b.Property<DateOnly>("ApplicationTime")
                        .HasColumnType("date");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("CreatedOn")
                        .HasColumnType("date");

                    b.Property<Guid>("CreatedTransactionId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uuid");

                    b.Property<DateOnly?>("DeletedOn")
                        .HasColumnType("date");

                    b.Property<Guid?>("DeletedTransactionId")
                        .HasColumnType("uuid");

                    b.Property<BitArray>("IsDeleted")
                        .IsRequired()
                        .HasColumnType("bit varying");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateOnly?>("ModifiedOn")
                        .HasColumnType("date");

                    b.Property<Guid?>("ModifiedTransactionId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("PatientId")
                        .HasColumnType("uuid");

                    b.HasKey("Id")
                        .HasName("CitizenApplication_pkey");

                    b.ToTable("CitizenApplication", "Patient");
                });

            modelBuilder.Entity("AHOS.Api.Models.Patient.CitizenApplicationService", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<Guid>("CitizenApplicationId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CityId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("CreatedOn")
                        .HasColumnType("date");

                    b.Property<Guid>("CreatedTransactionId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uuid");

                    b.Property<DateOnly?>("DeletedOn")
                        .HasColumnType("date");

                    b.Property<Guid?>("DeletedTransactionId")
                        .HasColumnType("uuid");

                    b.Property<BitArray>("IsDeleted")
                        .IsRequired()
                        .HasColumnType("bit varying");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateOnly?>("ModifiedOn")
                        .HasColumnType("date");

                    b.Property<Guid?>("ModifiedTransactionId")
                        .HasColumnType("uuid");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<Guid>("ServiceId")
                        .HasColumnType("uuid");

                    b.Property<string>("ServiceReferanceId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("CitizenApplicationService_pkey");

                    b.HasIndex("CitizenApplicationId");

                    b.HasIndex("ServiceId");

                    b.ToTable("CitizenApplicationService", "Patient");
                });

            modelBuilder.Entity("AHOS.Api.Models.Patient.CitizenPatient", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<BitArray>("Active")
                        .IsRequired()
                        .HasColumnType("bit(1)");

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("BirthPlace")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("CreatedOn")
                        .HasColumnType("date");

                    b.Property<Guid>("CreatedTransactionId")
                        .HasColumnType("uuid");

                    b.Property<BitArray>("Deceased")
                        .IsRequired()
                        .HasColumnType("bit(1)");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uuid");

                    b.Property<DateOnly?>("DeletedOn")
                        .HasColumnType("date");

                    b.Property<Guid?>("DeletedTransactionId")
                        .HasColumnType("uuid");

                    b.Property<string>("FatherName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("GenderId")
                        .HasColumnType("uuid");

                    b.Property<long>("IdentityNumber")
                        .HasColumnType("bigint");

                    b.Property<BitArray>("IsDeleted")
                        .IsRequired()
                        .HasColumnType("bit varying");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateOnly?>("ModifiedOn")
                        .HasColumnType("date");

                    b.Property<Guid?>("ModifiedTransactionId")
                        .HasColumnType("uuid");

                    b.Property<string>("MotherName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("CitizenPatient_pkey");

                    b.HasIndex("GenderId");

                    b.ToTable("CitizenPatient", "Patient");
                });

            modelBuilder.Entity("AHOS.Api.Models.Patient.NonCitizenPatient", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<BitArray>("Active")
                        .IsRequired()
                        .HasColumnType("bit(1)");

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date");

                    b.Property<Guid>("CreatedBy")
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("CreatedOn")
                        .HasColumnType("date");

                    b.Property<Guid>("CreatedTransactionId")
                        .HasColumnType("uuid");

                    b.Property<BitArray>("Deceased")
                        .IsRequired()
                        .HasColumnType("bit(1)");

                    b.Property<Guid?>("DeletedBy")
                        .HasColumnType("uuid");

                    b.Property<DateOnly?>("DeletedOn")
                        .HasColumnType("date");

                    b.Property<Guid?>("DeletedTransactionId")
                        .HasColumnType("uuid");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("GenderId")
                        .HasColumnType("uuid");

                    b.Property<BitArray>("IsDeleted")
                        .IsRequired()
                        .HasColumnType("bit varying");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("ModifiedBy")
                        .HasColumnType("uuid");

                    b.Property<DateOnly?>("ModifiedOn")
                        .HasColumnType("date");

                    b.Property<Guid?>("ModifiedTransactionId")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("NationalityId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("NoncitizenPatientTypeId")
                        .HasColumnType("uuid");

                    b.Property<string>("PassportNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<BitArray>("PassportNumberVerified")
                        .HasColumnType("bit(1)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("NonCitizenPatient_pkey");

                    b.HasIndex("NoncitizenPatientTypeId");

                    b.ToTable("NonCitizenPatient", "Patient");
                });

            modelBuilder.Entity("AHOS.Api.Models.Patient.CitizenApplicationService", b =>
                {
                    b.HasOne("AHOS.Api.Models.Patient.CitizenApplication", "CitizenApplication")
                        .WithMany("CitizenApplicationServices")
                        .HasForeignKey("CitizenApplicationId")
                        .IsRequired()
                        .HasConstraintName("FK_CitizenApplicationService_CitizenApplicationId");

                    b.HasOne("AHOS.Api.Models.Common.Service", "Service")
                        .WithMany("CitizenApplicationServices")
                        .HasForeignKey("ServiceId")
                        .IsRequired()
                        .HasConstraintName("FK_CitizenApplicationService_ServiceId");

                    b.Navigation("CitizenApplication");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("AHOS.Api.Models.Patient.CitizenPatient", b =>
                {
                    b.HasOne("AHOS.Api.Models.Common.Gender", "Gender")
                        .WithMany("CitizenPatients")
                        .HasForeignKey("GenderId")
                        .IsRequired()
                        .HasConstraintName("FK_Patient_Gender");

                    b.Navigation("Gender");
                });

            modelBuilder.Entity("AHOS.Api.Models.Patient.NonCitizenPatient", b =>
                {
                    b.HasOne("AHOS.Api.Models.Common.NoncitizenPatientType", "NoncitizenPatientType")
                        .WithMany("NonCitizenPatients")
                        .HasForeignKey("NoncitizenPatientTypeId")
                        .IsRequired()
                        .HasConstraintName("FK_Patient_NoncitizenPatientType");

                    b.Navigation("NoncitizenPatientType");
                });

            modelBuilder.Entity("AHOS.Api.Models.Common.Gender", b =>
                {
                    b.Navigation("CitizenPatients");
                });

            modelBuilder.Entity("AHOS.Api.Models.Common.NoncitizenPatientType", b =>
                {
                    b.Navigation("NonCitizenPatients");
                });

            modelBuilder.Entity("AHOS.Api.Models.Common.Service", b =>
                {
                    b.Navigation("CitizenApplicationServices");
                });

            modelBuilder.Entity("AHOS.Api.Models.Patient.CitizenApplication", b =>
                {
                    b.Navigation("CitizenApplicationServices");
                });
#pragma warning restore 612, 618
        }
    }
}
