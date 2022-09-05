using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechnicalTask.Data.Models;

namespace TechnicalTask.Service.Interface
{
    public interface IFinanceRateType
    {
        public Task<FinanceRateType> AddFinanceRateType(FinanceRateType financeRateType);
        public IEnumerable<FinanceRateType> GetFinanceRateTypes();
    }
}
