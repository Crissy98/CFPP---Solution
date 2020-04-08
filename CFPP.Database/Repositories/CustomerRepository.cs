using CFPP.Database.Context;
using CFPP.Database.Entities;
using CFPP.Database.iRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CFPP.Database.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        //DbContext Object - interaction with the database
        private readonly CFPPDbContext _context;

        //the constructor
        public CustomerRepository(CFPPDbContext context)
        {
            this._context = context;
        }

        //private List<Customer> _customerList;
        
        public void Dispose()
        {
            _context.Dispose();
        }

        //Get All Customers
        public List<Customer> GetAll()
        {
            var customers = _context.Customers.ToList();

            
                return customers;
            
        }
 
        public Customer Add(Customer customer)
        {

             _context.Customers.Add(customer);
            _context.SaveChanges();

            return customer;
        }

        public Customer Delete(int CustomerId)
        {
            //fisrt we want to find and retrieve the customer object that we want to delete
            Customer customer=_context.Customers.Find(CustomerId);

            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }

            return customer;
        }

   
        //get Customer by Code
        public Customer GetById(string CustomerCode)
        {
            Customer customersByCode=_context.Customers.Find(CustomerCode);
            return customersByCode;
        }

        public void Save()
        {
            
        }

        public Customer Edit(Customer customerChanged)
        {
            var modifiedCustomer = _context.Customers.Attach(customerChanged);

            modifiedCustomer.State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            _context.SaveChanges();

            //return updated custmer object
            return customerChanged;
        }
    }
}
