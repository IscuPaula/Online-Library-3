using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_Iscu_Paula.Models
{
    public class Categorii
    {
        public int ID { get; set; }
        public string NumeleCategoriei{ get; set; }
        public ICollection<Categorii> CategoriiH { get; set; }
    }
}
