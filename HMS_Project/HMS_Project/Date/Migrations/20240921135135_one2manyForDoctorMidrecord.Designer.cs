﻿// <auto-generated />
using System;
using HMS_Project.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HMS_Project.Date.Migrations
{
    [DbContext(typeof(HMSdbcontext))]
    [Migration("20240921135135_one2manyForDoctorMidrecord")]
    partial class one2manyForDoctorMidrecord
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

            modelBuilder.Entity("ActiveSubstancePatient", b =>
                {
                    b.Property<int>("ActSbuAllergiesActiveSubstancesId")
                        .HasColumnType("int");

                    b.Property<int>("PatientshaveAllergyPatientId")
                        .HasColumnType("int");

                    b.HasKey("ActSbuAllergiesActiveSubstancesId", "PatientshaveAllergyPatientId");

                    b.HasIndex("PatientshaveAllergyPatientId");

                    b.ToTable("ActiveSubstancePatient");
                });

            modelBuilder.Entity("ActiveSubstancePrescription", b =>
                {
                    b.Property<int>("ActiveSubstancesId")
                        .HasColumnType("int");

                    b.Property<int>("PrescriptionsPrescriptionID")
                        .HasColumnType("int");

                    b.HasKey("ActiveSubstancesId", "PrescriptionsPrescriptionID");

                    b.HasIndex("PrescriptionsPrescriptionID");

                    b.ToTable("ActiveSubstancePrescription");
                });

            modelBuilder.Entity("AvailableAppointmentDoctor", b =>
                {
                    b.Property<int>("AvailableAppointmentsAvailableAppointmentId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorsDoctorId")
                        .HasColumnType("int");

                    b.HasKey("AvailableAppointmentsAvailableAppointmentId", "DoctorsDoctorId");

                    b.HasIndex("DoctorsDoctorId");

                    b.ToTable("AvailableAppointmentDoctor");
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

                    b.ToTable("ActiveSubstances");
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

            modelBuilder.Entity("HMS_Project.model.Apointment", b =>
                {
                    b.Property<int>("ApointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ApointmentId"));

                    b.Property<DateOnly>("ApointmentDate")
                        .HasColumnType("date");

                    b.Property<string>("ApointmentStatus")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("char");

                    b.Property<TimeOnly>("ApointmentTime")
                        .HasColumnType("time");

                    b.Property<int>("ClinicId")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("ReceptionId")
                        .HasColumnType("int");

                    b.HasKey("ApointmentId");

                    b.HasIndex("ClinicId");

                    b.HasIndex("PatientId");

                    b.HasIndex("ReceptionId");

                    b.ToTable("Apointments");
                });

            modelBuilder.Entity("HMS_Project.model.AvailableAppointment", b =>
                {
                    b.Property<int>("AvailableAppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AvailableAppointmentId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("ShiftNumber")
                        .HasColumnType("int");

                    b.HasKey("AvailableAppointmentId");

                    b.ToTable("AvailableAppointments");
                });

            modelBuilder.Entity("HMS_Project.model.Clinic", b =>
                {
                    b.Property<int>("ClinicId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClinicId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Specilization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClinicId");

                    b.ToTable("Clinics");
                });

            modelBuilder.Entity("HMS_Project.model.ClinicAvailableAppointment", b =>
                {
                    b.Property<int>("ClinicId")
                        .HasColumnType("int");

                    b.Property<int>("AvailableAppointmentId")
                        .HasColumnType("int");

                    b.Property<int>("AvailableSlots")
                        .HasColumnType("int");

                    b.HasKey("ClinicId", "AvailableAppointmentId");

                    b.HasIndex("AvailableAppointmentId");

                    b.ToTable("ClinicAvailableAppointment");
                });

            modelBuilder.Entity("HMS_Project.model.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"));

                    b.Property<int>("ClinicId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

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

                    b.Property<long>("SSN")
                        .HasColumnType("bigint");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("DoctorId");

                    b.HasIndex("ClinicId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Doctors");
                });

            modelBuilder.Entity("HMS_Project.model.Invoice", b =>
                {
                    b.Property<int>("InvoiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InvoiceID"));

                    b.Property<DateTime>("InvoiceDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasComputedColumnSql("GETDATE()");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<bool>("PaymentStatus")
                        .HasColumnType("bit");

                    b.Property<string>("PaymentType")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("char");

                    b.Property<int>("ReceptionId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(12,2)");

                    b.HasKey("InvoiceID");

                    b.HasIndex("PatientId");

                    b.HasIndex("ReceptionId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("HMS_Project.model.MedicalRecord", b =>
                {
                    b.Property<int>("RecordID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecordID"));

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasComputedColumnSql("GETDATE()");

                    b.Property<string>("Diagnosis")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<string>("LabResults")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar");

                    b.Property<int>("PatientID")
                        .HasColumnType("int");

                    b.HasKey("RecordID");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientID");

                    b.ToTable("MedicalRecords");
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

                    b.Property<int>("Strength")
                        .HasColumnType("int");

                    b.HasKey("MedicationCode");

                    b.HasIndex("PharmacyID");

                    b.ToTable("Medication");
                });

            modelBuilder.Entity("HMS_Project.model.Nurse", b =>
                {
                    b.Property<int>("NurseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NurseId"));

                    b.Property<int>("ClinicId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

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

                    b.Property<long>("SSN")
                        .HasColumnType("bigint");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("NurseId");

                    b.HasIndex("ClinicId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Nurses");
                });

            modelBuilder.Entity("HMS_Project.model.Patient", b =>
                {
                    b.Property<int>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PatientId"));

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

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

                    b.Property<string>("PatAddress")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<long>("SSN")
                        .HasColumnType("bigint");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PatientId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Patients");
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

            modelBuilder.Entity("HMS_Project.model.Pharmacist", b =>
                {
                    b.Property<int>("PharmacistID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PharmacistID"));

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

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

                    b.Property<int>("PharmacyID")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<long>("SSN")
                        .HasColumnType("bigint");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PharmacistID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("PharmacyID");

                    b.ToTable("Pharmacists");
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

                    b.ToTable("Pharmacies");
                });

            modelBuilder.Entity("HMS_Project.model.Prescription", b =>
                {
                    b.Property<int>("PrescriptionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrescriptionID"));

                    b.Property<DateTime>("DateIssued")
                        .HasColumnType("datetime2");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<int>("Dosage")
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.Property<int>("PharmacyID")
                        .HasColumnType("int");

                    b.HasKey("PrescriptionID");

                    b.HasIndex("DoctorId");

                    b.HasIndex("PatientId");

                    b.HasIndex("PharmacyID");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("HMS_Project.model.Reception", b =>
                {
                    b.Property<int>("ReceptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReceptionId"));

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar");

                    b.HasKey("ReceptionId");

                    b.ToTable("Reception");
                });

            modelBuilder.Entity("HMS_Project.model.Receptionist", b =>
                {
                    b.Property<int>("ReceptionistID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReceptionistID"));

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

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

                    b.Property<int>("ReceptionID")
                        .HasColumnType("int");

                    b.Property<long>("SSN")
                        .HasColumnType("bigint");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ReceptionistID");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("ReceptionID");

                    b.ToTable("Receptionists");
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

            modelBuilder.Entity("ActiveSubstancePatient", b =>
                {
                    b.HasOne("HMS_Project.model.ActiveSubstance", null)
                        .WithMany()
                        .HasForeignKey("ActSbuAllergiesActiveSubstancesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HMS_Project.model.Patient", null)
                        .WithMany()
                        .HasForeignKey("PatientshaveAllergyPatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ActiveSubstancePrescription", b =>
                {
                    b.HasOne("HMS_Project.model.ActiveSubstance", null)
                        .WithMany()
                        .HasForeignKey("ActiveSubstancesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HMS_Project.model.Prescription", null)
                        .WithMany()
                        .HasForeignKey("PrescriptionsPrescriptionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AvailableAppointmentDoctor", b =>
                {
                    b.HasOne("HMS_Project.model.AvailableAppointment", null)
                        .WithMany()
                        .HasForeignKey("AvailableAppointmentsAvailableAppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HMS_Project.model.Doctor", null)
                        .WithMany()
                        .HasForeignKey("DoctorsDoctorId")
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

            modelBuilder.Entity("HMS_Project.model.Apointment", b =>
                {
                    b.HasOne("HMS_Project.model.Clinic", "Clinic")
                        .WithMany("Apointments")
                        .HasForeignKey("ClinicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HMS_Project.model.Patient", "Patient")
                        .WithMany("Apointments")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HMS_Project.model.Reception", "Reception")
                        .WithMany("Apointments")
                        .HasForeignKey("ReceptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinic");

                    b.Navigation("Patient");

                    b.Navigation("Reception");
                });

            modelBuilder.Entity("HMS_Project.model.ClinicAvailableAppointment", b =>
                {
                    b.HasOne("HMS_Project.model.AvailableAppointment", "AvailableAppointment")
                        .WithMany("ClinicAvailableAppointments")
                        .HasForeignKey("AvailableAppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HMS_Project.model.Clinic", "Clinic")
                        .WithMany("ClinicAvailableAppointments")
                        .HasForeignKey("ClinicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AvailableAppointment");

                    b.Navigation("Clinic");
                });

            modelBuilder.Entity("HMS_Project.model.Doctor", b =>
                {
                    b.HasOne("HMS_Project.model.Clinic", "Clinic")
                        .WithMany("Doctors")
                        .HasForeignKey("ClinicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinic");
                });

            modelBuilder.Entity("HMS_Project.model.Invoice", b =>
                {
                    b.HasOne("HMS_Project.model.Patient", "Patient")
                        .WithMany("Invoices")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HMS_Project.model.Reception", "Reception")
                        .WithMany("invoices")
                        .HasForeignKey("ReceptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Patient");

                    b.Navigation("Reception");
                });

            modelBuilder.Entity("HMS_Project.model.MedicalRecord", b =>
                {
                    b.HasOne("HMS_Project.model.Doctor", "Doctor")
                        .WithMany("MedicalRecords")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HMS_Project.model.Patient", "Patient")
                        .WithMany("MedicalRecords")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("HMS_Project.model.Medication", b =>
                {
                    b.HasOne("HMS_Project.model.Pharmacy", "Pharmacy")
                        .WithMany("Medications")
                        .HasForeignKey("PharmacyID")
                        .IsRequired();

                    b.Navigation("Pharmacy");
                });

            modelBuilder.Entity("HMS_Project.model.Nurse", b =>
                {
                    b.HasOne("HMS_Project.model.Clinic", "Clinic")
                        .WithMany("Nurses")
                        .HasForeignKey("ClinicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Clinic");
                });

            modelBuilder.Entity("HMS_Project.model.PatientMedication", b =>
                {
                    b.HasOne("HMS_Project.model.Medication", null)
                        .WithMany("PatientMedications")
                        .HasForeignKey("MedicationMedicationCode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HMS_Project.model.Patient", null)
                        .WithMany("PatientMedication")
                        .HasForeignKey("PatientPatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HMS_Project.model.Pharmacist", b =>
                {
                    b.HasOne("HMS_Project.model.Pharmacy", "Pharmacy")
                        .WithMany("Pharmacists")
                        .HasForeignKey("PharmacyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pharmacy");
                });

            modelBuilder.Entity("HMS_Project.model.Prescription", b =>
                {
                    b.HasOne("HMS_Project.model.Doctor", "Doctor")
                        .WithMany("Prescriptions")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HMS_Project.model.Patient", "Patient")
                        .WithMany("Prescriptions")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HMS_Project.model.Pharmacy", "Pharmacy")
                        .WithMany("Prescriptions")
                        .HasForeignKey("PharmacyID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Doctor");

                    b.Navigation("Patient");

                    b.Navigation("Pharmacy");
                });

            modelBuilder.Entity("HMS_Project.model.Receptionist", b =>
                {
                    b.HasOne("HMS_Project.model.Reception", "Reception")
                        .WithMany("Receptionists")
                        .HasForeignKey("ReceptionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reception");
                });

            modelBuilder.Entity("HMS_Project.model.ActiveSubstance", b =>
                {
                    b.Navigation("ActSub1");

                    b.Navigation("ActSub2");

                    b.Navigation("ActiveSubstancesSideEffects");
                });

            modelBuilder.Entity("HMS_Project.model.AvailableAppointment", b =>
                {
                    b.Navigation("ClinicAvailableAppointments");
                });

            modelBuilder.Entity("HMS_Project.model.Clinic", b =>
                {
                    b.Navigation("Apointments");

                    b.Navigation("ClinicAvailableAppointments");

                    b.Navigation("Doctors");

                    b.Navigation("Nurses");
                });

            modelBuilder.Entity("HMS_Project.model.Doctor", b =>
                {
                    b.Navigation("MedicalRecords");

                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("HMS_Project.model.Medication", b =>
                {
                    b.Navigation("PatientMedications");
                });

            modelBuilder.Entity("HMS_Project.model.Patient", b =>
                {
                    b.Navigation("Apointments");

                    b.Navigation("Invoices");

                    b.Navigation("MedicalRecords");

                    b.Navigation("PatientMedication");

                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("HMS_Project.model.Pharmacy", b =>
                {
                    b.Navigation("Medications");

                    b.Navigation("Pharmacists");

                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("HMS_Project.model.Reception", b =>
                {
                    b.Navigation("Apointments");

                    b.Navigation("Receptionists");

                    b.Navigation("invoices");
                });
#pragma warning restore 612, 618
        }
    }
}
