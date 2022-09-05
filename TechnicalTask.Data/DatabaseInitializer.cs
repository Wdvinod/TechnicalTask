using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechnicalTask.Data.Models;

namespace TechnicalTask.Data
{
    public static class DatabaseInitializer
    {
        public static void Initialize(ApplicationDbContext dbContext)
        {
            dbContext.Database.EnsureCreated();
            if (!dbContext.FinanceRateTypes.Any())
            {
                dbContext.Add(new FinanceRateType()
                {
                    Type = "0-3 Month"
                }
                );
                dbContext.Add(new FinanceRateType()
                {
                    Type = "3-6 Month"
                }
                );
                dbContext.Add(new FinanceRateType()
                {
                    Type = "6-12 Month"
                }
                );
                dbContext.Add(new FinanceRateType()
                {
                    Type = "12+ Month"
                }
                );
                dbContext.SaveChanges();
            }
        }
    }
}
