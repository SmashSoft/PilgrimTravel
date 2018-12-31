using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Temples.DataEntities.Models;

namespace Temples.Repository.DataContext
{
    public class DbInitializer
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<AppDbContext>();
            context.Database.EnsureCreated();

            if (!context.Dieties.Any()){
                context.Dieties.Add(new Diety() {
                    DietyName = "Ganapathi",
                    Description = "Pazhavangadi Maha Ganapathi",
                    Features = "Very popular Ganesha Temple in Trivandrum",
                    IsPrimary = true
                });
            };


            if(!context.Styles.Any())
            {
                context.Styles.Add(new Style()
                {
                    Name = "Architecture",
                    Description = "Based on Architectural style"
                });

                context.Styles.Add(new Style()
                {
                    Name = "Historical Importance",
                    Description = "Based on Historical Importance"
                });
            }


            if(!context.TempleTypes.Any())
            {
                context.TempleTypes.Add(new TempleType() {
                    Name="Private",
                    Description="Managed by Private trust"
                });
                context.TempleTypes.Add(new TempleType()
                {
                    Name = "Devaswom",
                    Description = "Managed by Devaswom bord"
                });
            }


            if(!context.Addresses.Any())
            {
                context.Addresses.Add(new Address()
                {
                    Address1 = "East Fort",
                    Address2 = "Pahavangadi",
                    Address3 = "",
                    State = "Kerala",
                    Taluk = "Trivandrum",
                    District = "Trivandrum",
                    ZipCode = 679001,
                    Created = DateTime.Now
                });
            }

            if(!context.Temples.Any())
            {
                context.Temples.Add(new Temple()
                {
                    Name = "Pazhavangadi Ganapathi Temple",
                    Note = "Managed by CRPF",
                    Created = DateTime.Now
                });
            }

            context.SaveChanges();
        }

       // private static Dictionary<string, Diety> _dieties;

    }
}
