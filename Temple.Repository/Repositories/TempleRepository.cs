using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Temples.DataEntities.Models;
using Temples.Repository.DataContext;
using Temples.Repository.Interface;

namespace Temples.Repository.Repositories
{
    public class TempleRepository : GenericRepository<Temple>, ITempleRepository
    {
        public TempleRepository(AppDbContext context):base(context)
        {

        }

        public AppDbContext AppDbContext
        {
            get
            {
                return _context as AppDbContext;
            }
        }        

        public IEnumerable<Temple> GetMajorTemples()
        {
            return AppDbContext.Temples.ToList();
        }


        public IEnumerable<Temple> Temples => AppDbContext.Temples;
    }
}
