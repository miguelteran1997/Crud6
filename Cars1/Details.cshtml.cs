using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUD6.Data;

namespace CRUD6.Pages.Cars1
{
    public class DetailsModel : PageModel
    {
        private readonly CRUD6.Data.ApplicationDbContext _context;

        public DetailsModel(CRUD6.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Cars Cars { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cars = await _context.Cars.FirstOrDefaultAsync(m => m.CID == id);

            if (Cars == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
