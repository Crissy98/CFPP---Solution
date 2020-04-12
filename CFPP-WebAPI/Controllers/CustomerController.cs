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
        //IGenericRepository
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
        public ActionResult<Customer> GetById(int id)
        {
            Customer customer = _customerRepository.Get(id);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }

        [Route("~/api/customer")]
        //POST: api/customer
        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            _customerRepository.Add(customer);
            return Ok(customer);
        }

    
    }
}
