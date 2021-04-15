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
    public class DetailsModel : PageModel
    {
        private readonly Expenses.Models.MyDbContext _context;

        public DetailsModel(Expenses.Models.MyDbContext context)
        {
            _context = context;
        }

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
    }
}
