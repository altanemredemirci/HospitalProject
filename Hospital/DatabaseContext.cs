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

        public DbSet<Il> Ils { get; set; }
        public DbSet<Ilce> Ilces { get; set; }
    }
}
/*    MICRO ORM - Object Relational Mapping
    C# ile MSSQL arasında ilişkilendirme, veri transferi ve projenin veritabanı yönetimini sağlayan hazır tasarlanmış ve kullanıcı dostu frameworklerdir.     
        *Ado.Net 42ms       
        *Entity Framework  682ms
        *Dapper 46ms



*/