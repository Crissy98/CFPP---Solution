using CFPP.Database.Context;
using CFPP.Database.Entities;
using CFPP.Database.iRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CFPP.Database.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly CFPPDbContext _context;
        public CustomerRepository(CFPPDbContext context)
        {
            this._context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public Customer Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer Delete(int CustomerId)
        {
            throw new NotImplementedException();
        }

        public Customer Edit(Customer Customer)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(string CustomerCode)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
