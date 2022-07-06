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
    public class DetailsModel : PageModel
    {
        private readonly WMS.Data.WMSContext _context;

        public DetailsModel(WMS.Data.WMSContext context)
        {
            _context = context;
        }

      public Login Login { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Login == null)
            {
                return NotFound();
            }

            var login = await _context.Login.FirstOrDefaultAsync(m => m.UserId == id);
            if (login == null)
            {
                return NotFound();
            }
            else 
            {
                Login = login;
            }
            return Page();
        }
    }
}
