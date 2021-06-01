using LivrariaAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaAPI.Repository
{
    public interface IBookRepository
    {
        List<Book> GetAll();
        Book GetById(long id);
        Book Create(Book book);
        Book Update(Book book);
        void Delete(long id);
        bool Exists(long id);
    }
}
