using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proiect_Iscu_Paula.Data;
using Proiect_Iscu_Paula.Models;

namespace Proiect_Iscu_Paula.Pages.Haine1
{
    public class EditModel : PageModel
    {
        private readonly Proiect_Iscu_Paula.Data.Proiect_Iscu_PaulaContext _context;

        public EditModel(Proiect_Iscu_Paula.Data.Proiect_Iscu_PaulaContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Haine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HaineExists(Haine.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool HaineExists(int id)
        {
            return _context.Haine.Any(e => e.ID == id);
        }
    }
}
