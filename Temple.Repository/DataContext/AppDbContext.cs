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

            builder.Entity<Temple>().HasData(
                new Temple
                {
                    ID = 1,
                    Name = "Pazhavangadi Ganapathi Temple",
                    Note = "Managed by CRPF",
                    Created = DateTime.Now,
                    AddressID=1,
                    StyleID=1
                    
                });

            builder.Entity<Address>().HasData(new Address {
                ID=1,
                Address1 = "East Fort",
                Address2 = "Pahavangadi",
                Address3 = "",
                State = "Kerala",
                Taluk = "Trivandrum",
                District = "Trivandrum",
                ZipCode = 679001,
                Created = DateTime.Now
                
                
            });

            builder.Entity<TempleBlob>().HasData(new TempleBlob
            {
                ID = 1,
                Importance = "Important template in Trivandrum",
                History = "Established in xxxx",
                Created = DateTime.Now,
                TempleID=1

            });

            builder.Entity<Style>().HasData(new Style
            {
                ID=1,
                Name = "Architecture",
                Description = "Based on Architectural style"
                
            });

            builder.Entity<Diety>().HasData(new Diety
            {
                ID=1,
                DietyName = "Ganapathi",
                Description = "Pazhavangadi Maha Ganapathi",
                Features = "Very popular Ganesha Temple in Trivandrum",
                IsPrimary = true,
                TempleID=1
            });

            builder.Entity<TempleType>().HasData(new TempleType
            {
                ID=1,
                Name = "Private",
                Description = "Managed by Private trust"
                
            });

        }


        public DbSet<Temple> Temples { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<TempleBlob> TempleBlobs { get; set; }
        public DbSet<Style> Styles { get; set; }
        public DbSet<TempleType> TempleTypes { get; set; }
        public DbSet<Diety> Dieties { get; set; }

    }
}
