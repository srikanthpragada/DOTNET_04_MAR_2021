using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Expenses.Models;
using Microsoft.AspNetCore.Authorization;

namespace Expenses.Pages
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly Expenses.Models.MyDbContext _context;

        public CreateModel(Expenses.Models.MyDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Expenditure Expenditure { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Expenses.Add(Expenditure);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
