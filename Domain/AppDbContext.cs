using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Data.Sql;


namespace DiplomProject.Domain
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<InfoAp> infoAps { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<InfoAp>().HasData(new InfoAp
            {
                ID = 4,
                Adress = " Горького ",
                Info = "Сломался компьютер, не включается",
                Phone = "8-88-8-87"
            }) ; 
        }
    }
}