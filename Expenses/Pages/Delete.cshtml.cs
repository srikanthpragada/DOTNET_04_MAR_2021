using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Expenses.Models;
using Microsoft.AspNetCore.Authorization;

namespace Expenses.Pages
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly Expenses.Models.MyDbContext _context;

        public DeleteModel(Expenses.Models.MyDbContext context)
        {
            _context = context;
        }

        public string Message { get; private set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                Message = "Expenditure Not Found!";
                return Page();
            }

            var expenditure = await _context.Expenses.FirstOrDefaultAsync(m => m.Id == id);

            if (expenditure == null)
            {
                Message = "Expenditure Not Found!";
                return Page();
            }

            _context.Expenses.Remove(expenditure);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

       
    }
}
