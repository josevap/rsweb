#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RSWEB_Proekt.Data;
using RSWEB_Proekt.Models;

namespace RSWEB_Proekt.Pages.Profesors
{
    public class CreateModel : PageModel
    {
        private readonly RSWEB_Proekt.Data.RSWEB_ProektContext _context;

        public CreateModel(RSWEB_Proekt.Data.RSWEB_ProektContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Profesor Profesor { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Profesor.Add(Profesor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
