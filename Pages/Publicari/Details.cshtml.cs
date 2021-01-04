using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Iscu_Paula.Data;
using Proiect_Iscu_Paula.Models;

namespace Proiect_Iscu_Paula.Pages.Publicari
{
    public class DetailsModel : PageModel
    {
        private readonly Proiect_Iscu_Paula.Data.Proiect_Iscu_PaulaContext _context;

        public DetailsModel(Proiect_Iscu_Paula.Data.Proiect_Iscu_PaulaContext context)
        {
            _context = context;
        }

        public Publicare Publicare { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Publicare = await _context.Publicare.FirstOrDefaultAsync(m => m.ID == id);

            if (Publicare == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
