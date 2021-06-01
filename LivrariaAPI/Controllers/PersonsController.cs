using Microsoft.AspNetCore.Mvc;
using LivrariaAPI.Data;
using LivrariaAPI.Model;
using System.Linq;
using LivrariaAPI.Business;

namespace LivrariaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonsController : Controller
    {
        private readonly IPersonBusiness _business;

        public PersonsController(IPersonBusiness business)
        {
            _business = business;
        }

        [HttpGet]
        public IActionResult Get()
        {
           
            return Ok(_business.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetBy(long id)
        {
           
            return Ok(_business.GetById(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] Person person)
        {
            
            return Ok(_business.Create(person));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Person person)
        {
           
            return Ok(_business.Update(person));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _business.Delete(id);
            return NoContent();
        }

        

        
    }
}
