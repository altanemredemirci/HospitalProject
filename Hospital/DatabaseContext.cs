using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class DatabaseContext:DbContext //EF paketinden inhareted
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-58CMK8T\\SQLDERS;Database=HospitalDB;Trusted_Connection=true; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Bütün Entity lerin birbiriyle olan ilişkilerini tanımlayacağız. 

            modelBuilder.Entity<Randevu>()
                .HasOne(r => r.Hasta)
                .WithMany(h => h.Randevus)
                .HasForeignKey(r => r.HastaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Randevu>()
               .HasOne(r => r.Klinik)
               .WithMany(k => k.Randevus)
               .HasForeignKey(r => r.KlinikId)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Randevu>()
              .HasOne(r => r.Doktor)
              .WithMany(d => d.Randevus)
              .HasForeignKey(r => r.DoktorId)
              .OnDelete(DeleteBehavior.Restrict);
        }

        public DbSet<Il> Ils { get; set; }
        public DbSet<Ilce> Ilces { get; set; }
        public DbSet<Hastahane> Hastahanes { get; set; }
        public DbSet<Hasta> Hastas { get; set; }
        public DbSet<Klinik> Kliniks { get; set; }
        public DbSet<Doktor> Doktors { get; set; }
        public DbSet<Randevu> Randevus { get; set; }
    }
}
/*    MICRO ORM - Object Relational Mapping
    C# ile MSSQL arasında ilişkilendirme, veri transferi ve projenin veritabanı yönetimini sağlayan hazır tasarlanmış ve kullanıcı dostu frameworklerdir.     
        *Ado.Net 42ms       
        *Entity Framework  682ms
        *Dapper 46ms



*/