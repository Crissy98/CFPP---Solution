
using CFPP.Database.Entities;
using CFPP.Database.iRepositories;
using Microsoft.AspNetCore.Mvc;

namespace CFPP_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaseController : ControllerBase
    {
        //IRepository
        private readonly ICaseRepository CaseRepository;

        //ctor
        public CaseController(ICaseRepository caseRepository)
        {
            CaseRepository = caseRepository;
        }

        [Route("~/api/case")]
        //[ResponseType(typeof(Student[]))]
        [HttpGet]
        public IActionResult GetAll()
        {
            var cases = CaseRepository.GetAll();

            if (cases == null)

                return NotFound();

            else

                return Ok(cases);
        }

        // GET: api/Case/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return id.ToString();
        }

        // POST: api/Case
        [HttpPost]
        public IActionResult Create(Case _case)
        {
            CaseRepository.Add(_case);
            return Ok(_case);
        }

        // PUT: api/Case/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
