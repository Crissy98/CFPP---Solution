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
            return Ok(customers);
        }


        [Route("~/api/customer")]
        //[ResponseType(typeof(Customer[]))]
        [HttpPost]
        public IActionResult Add(Customer customer)
        {
            var customers = _customerRepository.Add(customer);
            return Ok(customers);
        }
    }
}
