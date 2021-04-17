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
    public class BrowseModel : PageModel
    {
        private readonly MyDbContext _context;

        public BrowseModel(MyDbContext context)
        {
            _context = context;
        }

        public IList<Expenditure> Expenses { get;set; }
 
        public void OnGet()
        {
            Expenses = _context.Expenses
                               .OrderByDescending(e => e.SpentOn)
                               .ToList();

        }
    }
}
