using LivrariaAPI.Data;
using LivrariaAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaAPI.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly LivrariaAPIContext _context;
        public PersonRepository(LivrariaAPIContext context)
        {
            _context = context;
        }
        /// <summary>
        /// Cria novo item Person
        /// </summary>
        /// <param name="person">Dados Person JSON</param>
        /// <returns></returns>
        public Person Create(Person person)
        {
            _context.Person.Add(person);
            _context.SaveChanges();
            return person;
        }

        public void Delete(long id)
        {
            if (Exists(id))
            {
                var result =  _context.Person.SingleOrDefault(p => p.id.Equals(id));
                _context.Person.Remove(result);
                _context.SaveChanges();
            }
        }

        public List<Person> GetAll()
        {
            return _context.Person.ToList();
        }

        public Person GetById(long id)
        {
            return _context.Person.SingleOrDefault(p => p.id.Equals(id));
        }

        public Person Update(Person person)
        {
            throw new NotImplementedException();
        }
        public bool Exists(long id)
        {
            return _context.Person.Any(p => p.id.Equals(id));
        }
    }
}
