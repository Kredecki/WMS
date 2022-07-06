using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WMS.Data;
using WMS.Models;

namespace WMS.Pages.Account
{
    public class CreateModel : PageModel
    {
        private readonly WMS.Data.WMSContext _context;

        public CreateModel(WMS.Data.WMSContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Login Login { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Login == null || Login == null)
            {
                return Page();
            }

            _context.Login.Add(Login);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
