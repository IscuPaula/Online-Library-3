using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect_Iscu_Paula.Models
{
    public class CategoriiHaine
    {
        public int ID { get; set; }
        public int BHaineID { get; set; }
        public Haine Haine { get; set; }
        public int CategoriiID { get; set; }
        public Categorii Categorii { get; set; }
    }
}
