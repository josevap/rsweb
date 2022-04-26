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
    public class IndexModel : PageModel
    {
        private readonly RSWEB_Proekt.Data.RSWEB_ProektContext _context;

        public IndexModel(RSWEB_Proekt.Data.RSWEB_ProektContext context)
        {
            _context = context;
        }

        public IList<Profesor> Profesor { get;set; }

        public async Task OnGetAsync()
        {
            Profesor = await _context.Profesor.ToListAsync();
        }
    }
}
