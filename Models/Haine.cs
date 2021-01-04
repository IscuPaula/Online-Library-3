using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proiect_Iscu_Paula.Models
{
    public class Haine
    {
        public int ID { get; set; }
        [Display(Name = "Denumire")]
        public string Denumire { get; set; }
        public string Firma { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Pret { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataPublicarii { get; set; }
        public int PublicareID { get; set; }
        public Publicare Publicare { get; set; }
        public ICollection<Categorii> CategoriiH { get; set; }
    }
}
    
