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
    public class IndexModel : PageModel
    {
        private readonly CRUD6.Data.ApplicationDbContext _context;

        public IndexModel(CRUD6.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Cars> Cars { get;set; }

        public async Task OnGetAsync()
        {
            Cars = await _context.Cars.ToListAsync();
        }
    }
}
