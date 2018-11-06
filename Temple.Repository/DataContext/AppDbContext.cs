using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Temples.DataEntities.Models;

namespace Temples.Repository.DataContext
{
    public class AppDbContext:IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);  
        }


        public DbSet<Temple> Temples { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<TempleBlob> TempleBlobes { get; set; }
        public DbSet<Style> Styles { get; set; }
        public DbSet<TempleType> TempleTypes { get; set; }
        public DbSet<Diety> Dieties { get; set; }

    }
}
