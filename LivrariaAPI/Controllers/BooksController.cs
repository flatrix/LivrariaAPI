using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LivrariaAPI.Data;
using LivrariaAPI.Model;

namespace LivrariaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : Controller
    {
        private readonly LivrariaAPIContext _context;

        public BooksController(LivrariaAPIContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _context.Book.ToList();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetBy(long id)
        {
            var result = _context.Book.SingleOrDefault(b => b.id == id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Book book)
        {
            _context.Add(book);
            _context.SaveChanges();

            return Ok();
        }

        [HttpPut]
        public IActionResult Put([FromBody] Book book)
        {
            _context.Update(book);
            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            //var result = 
            _context.Remove(_context.Book.Find(id));
            _context.SaveChanges();

            return Ok();
        }
        private bool BookExists(long id)
        {
            return _context.Book.Any(e => e.id == id);
        }
    }
}
