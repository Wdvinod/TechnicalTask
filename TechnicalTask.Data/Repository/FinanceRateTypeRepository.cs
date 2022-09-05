using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TechnicalTask.Data.Models;

namespace TechnicalTask.Data.Repository
{
    public class FinanceRateTypeRepository : IRepository<FinanceRateType>
    {
        ApplicationDbContext _dbContext;
        public FinanceRateTypeRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public async Task<FinanceRateType> Create(FinanceRateType _object)
        {
            var obj = await _dbContext.FinanceRateTypes.AddAsync(_object);
            _dbContext.SaveChanges();
            return obj.Entity;
        }

        public IEnumerable<FinanceRateType> GetAll()
        {
            try
            {
                return _dbContext.FinanceRateTypes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
