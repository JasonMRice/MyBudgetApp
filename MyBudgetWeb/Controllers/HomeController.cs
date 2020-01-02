using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyBudgetWeb.Data;
using MyBudgetWeb.Models;

namespace MyBudgetWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Expenses()
        {
            return View();
        }

        public async Task<IActionResult> GetExpensesList()
        {
            List<Expense> expensesList = await _context.Expense.ToListAsync();
            return Json(expensesList);
        }

        public IActionResult GetNextThreeMonths()
        {
            List<DailyList> dailyList = new List<DailyList>();
            List<Expense> expensesList = _context.Expense.ToList();

            DateTime startDate = System.DateTime.Now;
            int i = 1;
            int twoWeekCounter = 1;
            decimal currentPaycheck = 0;
            int currentDay = startDate.Day;
            decimal runningTotal = 0;

            while(i <= 90)
            {
                var dayTotalList = _context.Expense.Where(e => e.DayOfMonth == startDate.Day).ToList();
                decimal dayTotal = 0;
                string currentDailyDescription = "";
                if(dayTotalList.Count() > 0 && startDate.Day <= 28)
                {
                    foreach(var item in dayTotalList)
                    {
                        dayTotal += item.Price;
                        currentDailyDescription += item.Description + ", ";
                    }
                }
                runningTotal -= dayTotal;
                if(twoWeekCounter % 14 == 0)
                {
                    currentPaycheck = 2000;
                    runningTotal += currentPaycheck;
                }
                else
                {
                    currentPaycheck = 0;
                }
                DailyList currentDailyList = new DailyList()
                {
                    DailyListId = i,
                    DailyDescription = currentDailyDescription,
                    Day = startDate,
                    DayTotal = dayTotal,
                    RunningTotal = runningTotal,
                    Paycheck = currentPaycheck,
                };
                startDate = startDate.AddDays(1);
                i++;
                twoWeekCounter++;
                dailyList.Add(currentDailyList);
            }


            return Json(dailyList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
