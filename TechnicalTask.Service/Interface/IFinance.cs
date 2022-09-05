using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechnicalTask.Data.Models;

namespace TechnicalTask.Service.Interface
{
    public interface IFinance
    {
        public Task<bool> AddFinance(Finance finance);
        public IEnumerable<Finance> GetFinances();
    }
}
