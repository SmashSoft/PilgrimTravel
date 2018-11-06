﻿using System;
using System.Collections.Generic;
using System.Text;
using Temples.DataEntities.Models;
using Temples.Repository.DataContext;
using Temples.Repository.Interface;

namespace Temples.Repository.Repositories
{
    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
        public AddressRepository(AppDbContext context) : base(context)
        {
        }
    }
}
