using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TechnicalTask.Data.Models;

namespace TechnicalTask.Data.Repository
{
    public class FinanceRepository : IRepository<Finance>
    {
        ApplicationDbContext _dbContext;
        public FinanceRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public async Task<Finance> Create(Finance _object)
        {
            try
            {
                var obj = await _dbContext.Finances.AddAsync(_object);
                _dbContext.SaveChanges();
                return obj.Entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Finance> GetAll()
        {
            try
            {
                return _dbContext.Finances.Include(c => c.FinanceType).Include(c => c.Make).Include(c => c.VehicleType).Include(c => c.FinanceRates);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
