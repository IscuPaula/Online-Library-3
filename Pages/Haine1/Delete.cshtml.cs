using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Iscu_Paula.Data;
using Proiect_Iscu_Paula.Models;

namespace Proiect_Iscu_Paula.Pages.Haine1
{
    public class DeleteModel : PageModel
    {
        private readonly Proiect_Iscu_Paula.Data.Proiect_Iscu_PaulaContext _context;

        public DeleteModel(Proiect_Iscu_Paula.Data.Proiect_Iscu_PaulaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Haine Haine { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Haine = await _context.Haine.FirstOrDefaultAsync(m => m.ID == id);

            if (Haine == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Haine = await _context.Haine.FindAsync(id);

            if (Haine != null)
            {
                _context.Haine.Remove(Haine);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
