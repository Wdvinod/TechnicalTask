using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechnicalTask.Data.Models;
using TechnicalTask.Data.Repository;
using TechnicalTask.Service.Interface;

namespace TechnicalTask.Service.Service
{
    public class FinanceRateTypeService : IFinanceRateType
    {
        private readonly IRepository<FinanceRateType> _financeRateType;

        public FinanceRateTypeService(IRepository<FinanceRateType> financeRateType)
        {
            _financeRateType = financeRateType;
        }
        public async Task<FinanceRateType> AddFinanceRateType(FinanceRateType make)
        {
            return await _financeRateType.Create(make);
        }
        public IEnumerable<FinanceRateType> GetFinanceRateTypes()
        {
            return _financeRateType.GetAll();
        }
    }
}
