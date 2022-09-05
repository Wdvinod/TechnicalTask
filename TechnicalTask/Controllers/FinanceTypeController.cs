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
    public class FinanceTypeController : ControllerBase
    {
        private readonly IFinanceType _financeTypeService;
        public FinanceTypeController(IFinanceType financeTypeService)
        {
            _financeTypeService = financeTypeService;
        }  
        [HttpPost("FinanceType")]
        public async Task<FinanceType> AddFinanceType([FromBody] FinanceType financeType)
        {
            try
            {
                return await _financeTypeService.AddFinanceType(financeType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet("FinanceType")]
        public Object GetFinanceTypes()
        {
            var financeTypes = _financeTypeService.GetFinanceTypes();
            return JsonConvert.SerializeObject(financeTypes, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );
        }
    }
}
