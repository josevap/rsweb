#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RSWEB_Proekt.Data;
using RSWEB_Proekt.Models;

namespace RSWEB_Proekt.Pages.Profesors
{
    public class DetailsModel : PageModel
    {
        private readonly RSWEB_Proekt.Data.RSWEB_ProektContext _context;

        public DetailsModel(RSWEB_Proekt.Data.RSWEB_ProektContext context)
        {
            _context = context;
        }

        public Profesor Profesor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Profesor = await _context.Profesor.FirstOrDefaultAsync(m => m.Id == id);

            if (Profesor == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
