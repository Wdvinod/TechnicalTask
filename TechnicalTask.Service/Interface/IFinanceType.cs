using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechnicalTask.Data.Models;

namespace TechnicalTask.Service.Interface
{
    public interface IFinanceType
    {
        public Task<FinanceType> AddFinanceType(FinanceType financeType);
        public IEnumerable<FinanceType> GetFinanceTypes();
    }
}
