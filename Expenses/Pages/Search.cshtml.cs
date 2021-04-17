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
    public class SearchModel : PageModel
    {
        private readonly MyDbContext _context;

        public SearchModel(MyDbContext context)
        {
            _context = context;
        }

        public IList<Expenditure> Expenses { get;set; }
 
        public void OnGet()
        {
            Expenses = null; 
        }

        public void OnPost(string title)
        {
            Expenses = _context.Expenses
                               .Where(e => e.Title.Contains(title))
                               .OrderByDescending( e => e.Id)
                               .ToList();

        }
    }
}
