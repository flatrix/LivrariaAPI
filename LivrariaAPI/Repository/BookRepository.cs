using LivrariaAPI.Data;
using LivrariaAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaAPI.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly LivrariaAPIContext _context;
        public BookRepository(LivrariaAPIContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Cria novo item Person
        /// </summary>
        /// <param name="book">Dados Book JSON</param>
        /// <returns></returns>
        public Book Create(Book book)
        {
            _context.Book.Add(book);
            _context.SaveChanges();
            return book;
        }

        public void Delete(long id)
        {
            if (Exists(id))
            {
                var result =  _context.Book.SingleOrDefault(p => p.id.Equals(id));
                _context.Book.Remove(result);
                _context.SaveChanges();
            }
        }

        public List<Book> GetAll()
        {
            return _context.Book.ToList();
        }

        public Book GetById(long id)
        {
            return _context.Book.SingleOrDefault(p => p.id.Equals(id));
        }

        public Book Update(Book book)
        {
            throw new NotImplementedException();
        }
        public bool Exists(long id)
        {
            return _context.Book.Any(p => p.id.Equals(id));
        }
    }
}
