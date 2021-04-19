using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Expenses.Models;
using Microsoft.AspNetCore.Authorization;

namespace Expenses.Pages
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly Expenses.Models.MyDbContext _context;

        public EditModel(Expenses.Models.MyDbContext context)
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

            Expenditure = await _context.Expenses.FirstOrDefaultAsync(e => e.Id == id);

            if (Expenditure == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Expenditure).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExpenditureExists(Expenditure.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ExpenditureExists(int id)
        {
            return _context.Expenses.Any(e => e.Id == id);
        }
    }
}
