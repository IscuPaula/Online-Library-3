using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect_Iscu_Paula.Data;
using Proiect_Iscu_Paula.Models;

namespace Proiect_Iscu_Paula.Pages.Categorii1
{
    public class CreateModel : PageModel
    {
        private readonly Proiect_Iscu_Paula.Data.Proiect_Iscu_PaulaContext _context;

        public CreateModel(Proiect_Iscu_Paula.Data.Proiect_Iscu_PaulaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Categorii Categorii { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Categorii.Add(Categorii);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
