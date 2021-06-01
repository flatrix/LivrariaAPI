using LivrariaAPI.Data;
using LivrariaAPI.Model;
using LivrariaAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaAPI.Business
{
    public class BookBusiness : IBookBusiness
    {
        private readonly IBookRepository _repository;
        public BookBusiness(IBookRepository repository)
        {
            _repository = repository;
        }
        
        public Book Create(Book book)
        {
           return _repository.Create(book);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public bool Exists(long id)
        {
            return _repository.Exists(id);
        }

        public List<Book> GetAll()
        {
            return _repository.GetAll();
        }

        public Book GetById(long id)
        {
            return _repository.GetById(id);
        }

        public Book Update(Book book)
        {
            return _repository.Update(book);
        }
    }
}
