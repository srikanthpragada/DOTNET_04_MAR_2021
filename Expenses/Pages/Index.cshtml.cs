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
    public class IndexModel : PageModel
    {
        private readonly MyDbContext _context;

        public IndexModel(MyDbContext context)
        {
            _context = context;
        }

        public IList<Expenditure> Expenses { get;set; }

        //public async Task OnGetAsync()
        //{
        //    Expenditure = await _context.Expenses.ToListAsync();
        //}

        public void OnGet()
        {
            Expenses = _context.Expenses
                               .OrderByDescending(e => e.Id)
                               .Take(10)
                               .ToList();

        }
    }
}
