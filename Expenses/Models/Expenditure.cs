using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Expenses.Models
{
    public class Expenditure
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string  Title { get; set; }
        public int Amount { get; set; }
        
        public DateTime SpentOn { get; set; }
        public int Category { get; set; }
    }
}
