using System;
using System.Collections.Generic;
using System.Text;
using Temples.DataEntities.Models;
using Temples.Repository.DataContext;
using Temples.Repository.Interface;

namespace Temples.Repository.Repositories
{
    public class StyleRepository : GenericRepository<Style>, IStyleRepository
    {
        public StyleRepository(AppDbContext context) : base(context)
        {
        }
    }
}
