﻿using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Application.Repositories.CustomerRepository;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistance.Repositories.CustomerRepository
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(ETicaretAPIDbContext eTicaretAPIDbContext) : base(eTicaretAPIDbContext)
        {
        }
    }
}
