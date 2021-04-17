using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Expenses.Models
{
    public static class Utilities
    {
        static string[] categories = 
            {"Education", "Entertainment", "Food", "Others" };
        public static string GetCategoryName(int category)
        {
            return categories[category - 1];
        }
    }
}
