﻿// <auto-generated />
using Hospital;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hospital.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20241203164639_UpdateHasta")]
    partial class UpdateHasta
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hospital.Doktor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Brans")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KlinikID")
                        .HasColumnType("int");

                    b.Property<string>("Unvan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KlinikID");

                    b.ToTable("Doktors");
                });

            modelBuilder.Entity("Hospital.Hasta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Boy")
                        .HasColumnType("int");

                    b.Property<int>("IlceId")
                        .HasColumnType("int");

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Kangrubu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kilo")
                        .HasColumnType("int");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TC")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("TakipliMi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IlceId");

                    b.ToTable("Hastas");
                });

            modelBuilder.Entity("Hospital.Hastahane", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IlceId")
                        .HasColumnType("int");

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IlceId");

                    b.ToTable("Hastahanes");
                });

            modelBuilder.Entity("Hospital.Il", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ils");
                });

            modelBuilder.Entity("Hospital.Ilce", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IlId")
                        .HasColumnType("int");

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("IlId");

                    b.ToTable("Ilces");
                });

            modelBuilder.Entity("Hospital.Klinik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("HastahaneId")
                        .HasColumnType("int");

                    b.Property<string>("Isim")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HastahaneId");

                    b.ToTable("Kliniks");
                });

            modelBuilder.Entity("Hospital.Randevu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DoktorId")
                        .HasColumnType("int");

                    b.Property<int>("HastaId")
                        .HasColumnType("int");

                    b.Property<int>("KlinikId")
                        .HasColumnType("int");

                    b.Property<string>("_RandevuSaati")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_RandevuTarihi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DoktorId");

                    b.HasIndex("HastaId");

                    b.HasIndex("KlinikId");

                    b.ToTable("Randevus");
                });

            modelBuilder.Entity("Hospital.Doktor", b =>
                {
                    b.HasOne("Hospital.Klinik", "Klinik")
                        .WithMany("Doktors")
                        .HasForeignKey("KlinikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Klinik");
                });

            modelBuilder.Entity("Hospital.Hasta", b =>
                {
                    b.HasOne("Hospital.Ilce", "Ilce")
                        .WithMany()
                        .HasForeignKey("IlceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ilce");
                });

            modelBuilder.Entity("Hospital.Hastahane", b =>
                {
                    b.HasOne("Hospital.Ilce", "Ilce")
                        .WithMany("Hastahanes")
                        .HasForeignKey("IlceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ilce");
                });

            modelBuilder.Entity("Hospital.Ilce", b =>
                {
                    b.HasOne("Hospital.Il", "Il")
                        .WithMany("Ilces")
                        .HasForeignKey("IlId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Il");
                });

            modelBuilder.Entity("Hospital.Klinik", b =>
                {
                    b.HasOne("Hospital.Hastahane", "Hastahane")
                        .WithMany("Kliniks")
                        .HasForeignKey("HastahaneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hastahane");
                });

            modelBuilder.Entity("Hospital.Randevu", b =>
                {
                    b.HasOne("Hospital.Doktor", "Doktor")
                        .WithMany("Randevus")
                        .HasForeignKey("DoktorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Hospital.Hasta", "Hasta")
                        .WithMany("Randevus")
                        .HasForeignKey("HastaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Hospital.Klinik", "Klinik")
                        .WithMany("Randevus")
                        .HasForeignKey("KlinikId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Doktor");

                    b.Navigation("Hasta");

                    b.Navigation("Klinik");
                });

            modelBuilder.Entity("Hospital.Doktor", b =>
                {
                    b.Navigation("Randevus");
                });

            modelBuilder.Entity("Hospital.Hasta", b =>
                {
                    b.Navigation("Randevus");
                });

            modelBuilder.Entity("Hospital.Hastahane", b =>
                {
                    b.Navigation("Kliniks");
                });

            modelBuilder.Entity("Hospital.Il", b =>
                {
                    b.Navigation("Ilces");
                });

            modelBuilder.Entity("Hospital.Ilce", b =>
                {
                    b.Navigation("Hastahanes");
                });

            modelBuilder.Entity("Hospital.Klinik", b =>
                {
                    b.Navigation("Doktors");

                    b.Navigation("Randevus");
                });
#pragma warning restore 612, 618
        }
    }
}
