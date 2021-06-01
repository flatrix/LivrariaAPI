using LivrariaAPI.Data;
using LivrariaAPI.Model;
using LivrariaAPI.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaAPI.Business
{
    public class PersonBusiness : IPersonBusiness
    {
        private readonly IPersonRepository _repository;
        public PersonBusiness(IPersonRepository repository)
        {
            _repository = repository;
        }
        
        public Person Create(Person person)
        {
           return _repository.Create(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public bool Exists(long id)
        {
            return _repository.Exists(id);
        }

        public List<Person> GetAll()
        {
            return _repository.GetAll();
        }

        public Person GetById(long id)
        {
            return _repository.GetById(id);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }
    }
}
