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
    public class FinanceRateTypeController : ControllerBase
    {
        private readonly IFinanceRateType _financeRateType;
        public FinanceRateTypeController(IFinanceRateType financeRateTypeService)
        {
            _financeRateType = financeRateTypeService;
        }
        
        [HttpPost("FinanceRateType")]
        public async Task<FinanceRateType> AddFinanceRateType([FromBody] FinanceRateType financeRateType)
        {
            try
            {
                return await _financeRateType.AddFinanceRateType(financeRateType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
   
        [HttpGet("FinanceRateTypes")]
        public Object GetFinanceRateTypes()
        {
            var financeRateTypes = _financeRateType.GetFinanceRateTypes();
            return JsonConvert.SerializeObject(financeRateTypes, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );
        }
    }
}
