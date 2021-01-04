using System.Collections.Generic;

namespace Proiect_Iscu_Paula.Models
{
    public class Publicare
    {
        public int ID { get; set; }
        public string NumelePublicarii { get; set; }
        public ICollection<Haine> Haine1 { get; set; }
    }
}