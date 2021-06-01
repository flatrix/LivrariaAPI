using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaAPI.Model
{
    /// <summary>
    /// Class de Pessoa
    /// </summary>
    [Table("person")]
    public class Person
    {
        public long id { get; set; }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string gender { get; set; }
    }
}
