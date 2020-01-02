using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyBudgetWeb.Models
{
    public class Expense
    {
        [Key]
        public int ExpenseId { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int DayOfMonth { get; set; }
    }
}
