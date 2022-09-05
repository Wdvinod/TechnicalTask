using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechnicalTask.Data.Models;
using TechnicalTask.Data.Repository;
using TechnicalTask.Service.Interface;

namespace TechnicalTask.Service.Service
{
    public class FinanceTypeService : IFinanceType
    {
        private readonly IRepository<FinanceType> _financeType;

        public FinanceTypeService(IRepository<FinanceType> financeType)
        {
            _financeType = financeType;
        }
        public async Task<FinanceType> AddFinanceType(FinanceType make)
        {
            return await _financeType.Create(make);
        }
        public IEnumerable<FinanceType> GetFinanceTypes()
        {
            return _financeType.GetAll();
        }
    }
}
