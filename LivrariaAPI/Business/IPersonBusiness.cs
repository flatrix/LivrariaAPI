using LivrariaAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaAPI.Business
{
    public interface IPersonBusiness
    {
        List<Person> GetAll();
        Person GetById(long id);
        Person Create(Person person);
        Person Update(Person person);
        void Delete(long id);
        bool Exists(long id);
    }
}
