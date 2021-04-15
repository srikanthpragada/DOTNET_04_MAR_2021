using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Expenses.Models;

namespace Expenses.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly Expenses.Models.MyDbContext _context;

        public DeleteModel(Expenses.Models.MyDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Expenditure Expenditure { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Expenditure = await _context.Expenses.FirstOrDefaultAsync(m => m.Id == id);

            if (Expenditure == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Expenditure = await _context.Expenses.FindAsync(id);

            if (Expenditure != null)
            {
                _context.Expenses.Remove(Expenditure);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
