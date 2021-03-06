﻿using CFPP.Database.Context;
using CFPP.Database.Entities;
using CFPP.Database.iRepositories;

namespace CFPP.Database.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {

        public CustomerRepository(CFPPDbContext context)
           : base(context)
        {
        }
    }
}
