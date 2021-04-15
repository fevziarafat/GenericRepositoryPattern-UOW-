using System;
using Microsoft.EntityFrameworkCore;
using PersonelApp.Domain;

namespace PersonelApp.DAL
{
     public class PersonelContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source =.;
            Initial Catalog = Personel;
            Integrated Security = True; Connect Timeout = 30; " +
                                        "Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;" +
                                        "MultiSubnetFailover=False");
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Personel> Personels { get; set; }
    }
}
