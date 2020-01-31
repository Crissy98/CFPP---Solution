using CFPP.Database.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CFPP.Database.iRepositories
{
    public interface ICustomerRepository : IDisposable
    {
        List<Customer> GetAll();
        Customer GetById(string CustomerCode);
        Customer Add(Customer customer);
        Customer Edit(Customer Customer);
        Customer Delete(int CustomerId);
        void Save();
    }
}
