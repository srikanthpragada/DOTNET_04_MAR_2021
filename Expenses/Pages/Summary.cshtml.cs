using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Expenses.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Expenses.Pages
{
    public class SummaryModel : PageModel
    {
        private readonly MyDbContext _context;

        public SummaryModel(MyDbContext context)
        {
            _context = context;
        }

        public int Total { get; private set; }

        public void OnGet()
        {
            Total = _context.Expenses.Sum(e => e.Amount);
        }
    }
}
