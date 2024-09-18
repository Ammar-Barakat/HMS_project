﻿// <auto-generated />
using System;
using HMS_Project.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HMS_Project.Migrations
{
    [DbContext(typeof(HMSdbcontext))]
    [Migration("20240918032427_mappingActSubAndMedicatoin")]
    partial class mappingActSubAndMedicatoin
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ActiveSubstanceMedication", b =>
                {
                    b.Property<int>("ActiveSubstancesId")
                        .HasColumnType("int");

                    b.Property<string>("MedicationCodesMedicationCode")
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("ActiveSubstancesId", "MedicationCodesMedicationCode");

                    b.HasIndex("MedicationCodesMedicationCode");

                    b.ToTable("ActiveSubstanceMedication");
                });

            modelBuilder.Entity("HMS_Project.model.ActiveSubstance", b =>
                {
                    b.Property<int>("ActiveSubstancesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ActiveSubstancesId"));

                    b.Property<string>("ActiveSubstancesName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ActiveSubstancesId");

                    b.HasIndex("ActiveSubstancesName")
                        .IsUnique();

                    b.ToTable("ActiveSubstance");
                });

            modelBuilder.Entity("HMS_Project.model.ActiveSubstanceInteraction", b =>
                {
                    b.Property<int>("ActiveSubstanceId1")
                        .HasColumnType("int");

                    b.Property<int>("ActiveSubstanceId2")
                        .HasColumnType("int");

                    b.Property<string>("Interaction")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ActiveSubstanceId1", "ActiveSubstanceId2");

                    b.HasIndex("ActiveSubstanceId2");

                    b.ToTable("ActiveSubstanceInteraction");
                });

            modelBuilder.Entity("HMS_Project.model.ActiveSubstancesSideEffect", b =>
                {
                    b.Property<string>("SideEffects")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("ActiveSubstancesId")
                        .HasColumnType("int")
                        .HasColumnName("ActiveSubstancesID");

                    b.HasKey("SideEffects", "ActiveSubstancesId");

                    b.HasIndex("ActiveSubstancesId");

                    b.ToTable("ActiveSubstancesSideEffect");
                });

            modelBuilder.Entity("HMS_Project.model.HmsUser", b =>
                {
                    b.Property<long>("SSN")
                        .HasColumnType("bigint");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Gender")
                        .HasMaxLength(1)
                        .HasColumnType("nchar(1)")
                        .IsFixedLength();

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("SSN");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("HmsUsers");

                    b.HasDiscriminator().HasValue("HmsUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("HMS_Project.model.Medication", b =>
                {
                    b.Property<string>("MedicationCode")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("MedName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PharmacyID")
                        .HasColumnType("int");

                    b.Property<int?>("PharmacyID1")
                        .HasColumnType("int");

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.HasKey("MedicationCode");

                    b.HasIndex("PharmacyID");

                    b.HasIndex("PharmacyID1");

                    b.ToTable("Medication");
                });

            modelBuilder.Entity("HMS_Project.model.PatientMedication", b =>
                {
                    b.Property<int>("PatientPatientId")
                        .HasColumnType("int");

                    b.Property<string>("MedicationMedicationCode")
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateOnly>("DateIssued")
                        .HasColumnType("date");

                    b.HasKey("PatientPatientId", "MedicationMedicationCode");

                    b.HasIndex("MedicationMedicationCode");

                    b.ToTable("PatientMedication");
                });

            modelBuilder.Entity("HMS_Project.model.Pharmacy", b =>
                {
                    b.Property<int>("PharmacyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PharmacyID"));

                    b.Property<string>("PharmacyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PharmacyPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PharmacyID");

                    b.ToTable("Pharmacy");
                });

            modelBuilder.Entity("HMS_Project.model.Prescription", b =>
                {
                    b.Property<int>("PrescriptionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrescriptionID"));

                    b.Property<int?>("ActiveSubstancesId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateIssued")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoctorID")
                        .HasColumnType("int");

                    b.Property<int>("Dosage")
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.Property<int>("PharmacyId")
                        .HasColumnType("int");

                    b.HasKey("PrescriptionID");

                    b.HasIndex("ActiveSubstancesId");

                    b.ToTable("Prescription");
                });

            modelBuilder.Entity("HMS_Project.model.Patient", b =>
                {
                    b.HasBaseType("HMS_Project.model.HmsUser");

                    b.Property<int?>("ActiveSubstancesId")
                        .HasColumnType("int");

                    b.Property<string>("PatAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasIndex("ActiveSubstancesId");

                    b.HasDiscriminator().HasValue("Patient");
                });

            modelBuilder.Entity("ActiveSubstanceMedication", b =>
                {
                    b.HasOne("HMS_Project.model.ActiveSubstance", null)
                        .WithMany()
                        .HasForeignKey("ActiveSubstancesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HMS_Project.model.Medication", null)
                        .WithMany()
                        .HasForeignKey("MedicationCodesMedicationCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HMS_Project.model.ActiveSubstanceInteraction", b =>
                {
                    b.HasOne("HMS_Project.model.ActiveSubstance", "ActSub1")
                        .WithMany("ActSub1")
                        .HasForeignKey("ActiveSubstanceId1")
                        .IsRequired();

                    b.HasOne("HMS_Project.model.ActiveSubstance", "ActSub2")
                        .WithMany("ActSub2")
                        .HasForeignKey("ActiveSubstanceId2")
                        .IsRequired();

                    b.Navigation("ActSub1");

                    b.Navigation("ActSub2");
                });

            modelBuilder.Entity("HMS_Project.model.ActiveSubstancesSideEffect", b =>
                {
                    b.HasOne("HMS_Project.model.ActiveSubstance", "ActiveSubstances")
                        .WithMany("ActiveSubstancesSideEffects")
                        .HasForeignKey("ActiveSubstancesId")
                        .IsRequired();

                    b.Navigation("ActiveSubstances");
                });

            modelBuilder.Entity("HMS_Project.model.Medication", b =>
                {
                    b.HasOne("HMS_Project.model.Pharmacy", "Pharmacy")
                        .WithMany()
                        .HasForeignKey("PharmacyID")
                        .IsRequired();

                    b.HasOne("HMS_Project.model.Pharmacy", null)
                        .WithMany("Medications")
                        .HasForeignKey("PharmacyID1");

                    b.Navigation("Pharmacy");
                });

            modelBuilder.Entity("HMS_Project.model.PatientMedication", b =>
                {
                    b.HasOne("HMS_Project.model.Medication", null)
                        .WithMany("PatientMedications")
                        .HasForeignKey("MedicationMedicationCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HMS_Project.model.Prescription", b =>
                {
                    b.HasOne("HMS_Project.model.ActiveSubstance", null)
                        .WithMany("Prescriptions")
                        .HasForeignKey("ActiveSubstancesId");
                });

            modelBuilder.Entity("HMS_Project.model.Patient", b =>
                {
                    b.HasOne("HMS_Project.model.ActiveSubstance", null)
                        .WithMany("Patients")
                        .HasForeignKey("ActiveSubstancesId");
                });

            modelBuilder.Entity("HMS_Project.model.ActiveSubstance", b =>
                {
                    b.Navigation("ActSub1");

                    b.Navigation("ActSub2");

                    b.Navigation("ActiveSubstancesSideEffects");

                    b.Navigation("Patients");

                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("HMS_Project.model.Medication", b =>
                {
                    b.Navigation("PatientMedications");
                });

            modelBuilder.Entity("HMS_Project.model.Pharmacy", b =>
                {
                    b.Navigation("Medications");
                });
#pragma warning restore 612, 618
        }
    }
}
