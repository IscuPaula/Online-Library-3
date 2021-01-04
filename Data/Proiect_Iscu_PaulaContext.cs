using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect_Iscu_Paula.Models;

namespace Proiect_Iscu_Paula.Data
{
    public class Proiect_Iscu_PaulaContext : DbContext
    {
        public Proiect_Iscu_PaulaContext (DbContextOptions<Proiect_Iscu_PaulaContext> options)
            : base(options)
        {
        }

        public DbSet<Proiect_Iscu_Paula.Models.Haine> Haine { get; set; }

        public DbSet<Proiect_Iscu_Paula.Models.Publicare> Publicare { get; set; }

        public DbSet<Proiect_Iscu_Paula.Models.Categorii> Categorii { get; set; }
    }
}
