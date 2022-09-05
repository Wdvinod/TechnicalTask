using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using TechnicalTask.Data.Models;
using TechnicalTask.Service.Interface;

namespace TechnicalTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinanceController : ControllerBase
    {
        private readonly IFinance _financeService;
        public FinanceController(IFinance financeService)
        {
            _financeService = financeService;
        }

        [HttpPost("Finance")]
        public async Task<bool> AddFinance([FromBody] Finance finance)
        {
            try
            {
                return await _financeService.AddFinance(finance);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet("Finances")]
        public Object GetFinanceRates()
        {
            var finances = _financeService.GetFinances();
            return JsonConvert.SerializeObject(finances, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );
        }
    }
}
