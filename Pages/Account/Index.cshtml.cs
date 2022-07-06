using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WMS.Data;
using WMS.Models;

namespace WMS.Pages.Account
{
    public class IndexModel : PageModel
    {
        private readonly WMS.Data.WMSContext _context;

        public IndexModel(WMS.Data.WMSContext context)
        {
            _context = context;
        }

        public IList<Login> Login { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Login != null)
            {
                Login = await _context.Login.ToListAsync();
            }
        }
    }
}
