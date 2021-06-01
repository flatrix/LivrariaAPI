using LivrariaAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaAPI.Business
{
    public interface IBookBusiness
    {
        List<Book> GetAll();
        Book GetById(long id);
        Book Create(Book book);
        Book Update(Book book);
        void Delete(long id);
        bool Exists(long id);
    }
}
