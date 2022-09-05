using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechnicalTask.Data.Models;
using TechnicalTask.Data.Repository;
using TechnicalTask.Service.Interface;

namespace TechnicalTask.Service.Service
{
    public class FinanceService : IFinance
    {
        private readonly IRepository<Finance> _finance;

        public FinanceService(IRepository<Finance> finance)
        {
            _finance = finance;
        }
        public async Task<bool> AddFinance(Finance finance)
        {
            var entity = await _finance.Create(finance);
            return entity.Id > 0 ? true : false;
        }
        public IEnumerable<Finance> GetFinances()
        {
            return _finance.GetAll();
        }
    }
}
