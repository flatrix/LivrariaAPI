using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaAPI.Model
{
    [Table("book")]
    public class Book
    {
        public long id { get; set; }
        
        public string name { get; set; }
        public long editor { get; set; }
        public int pages { get; set; }
        public decimal value { get; set; }

        public int anoLancamento { get; set; }
    }
}
