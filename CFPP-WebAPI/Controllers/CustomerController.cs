using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CFPP.Database.Entities;
using CFPP.Database.iRepositories;
using CFPP.Database.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CFPP_WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        //Repository
        private readonly ICustomerRepository _customerRepository;

        //ctor
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }


        [Route("~/api/customer")]
        //[ResponseType(typeof(Student[]))]
        [HttpGet]
         public IActionResult GetAll()
        {
            var customers = _customerRepository.GetAll();

            if (customers == null)
               
                return NotFound();

            else

            return Ok(customers);
        }

        [Route("~/api/customer/{id}")]
        [HttpGet("{id}")]
        public ActionResult<Customer> GetCustomerById(int id)
        {
            Customer customer = _customerRepository.GetById(id);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        } 

        [Route("~/api/customer")]
        //[ResponseType(typeof(Customer[]))]
        [HttpPost]
        public IActionResult AddNewCustomer(Customer customer)
        {
            Customer newCustomer = _customerRepository.Add(customer);
            return Ok(newCustomer);
        }

        [HttpPut("{id}")]
        public Customer Put(int id,Customer changedCustomer)
        {
            var customerChanged = _customerRepository.Edit(id, changedCustomer);

            return customerChanged;
        }
    }
}
