using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyBudgetWeb.Models;

namespace MyBudgetWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Expense> Expense { get; set; }
        public DbSet<DailyList> DailyList { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
