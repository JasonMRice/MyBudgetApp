using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyBudgetWeb.Models
{
    public class DailyList
    {
        [Key]
        public int DailyListId { get; set; }
        public string DailyDescription { get; set; }
        public DateTime Day { get; set; }
        public decimal DayTotal { get; set; }
        public decimal RunningTotal { get; set; }
        public decimal Paycheck { get; set; }
    }
}
