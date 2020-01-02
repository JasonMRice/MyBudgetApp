using MyBudgetWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBudgetWeb.ViewModel
{
    public class ExpenseViewModel
    {
        public Expense Expense { get; set; } = new Expense();
        public int ExpenseIdForEdit { get; set; }
        public decimal PriceForEdit { get; set; }
        public string DescriptionForEdit { get; set; }
        public int DayOfMonthForEdit { get; set; }
    }
}
