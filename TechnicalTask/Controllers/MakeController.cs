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
    public class MakeController : ControllerBase
    {
        private readonly IMake _makeService;
        public MakeController(IMake makeService)
        {
            _makeService = makeService;
        }  
        [HttpPost("Make")]
        public async Task<Make> AddMake([FromBody] Make make)
        {
            try
            {
                return await _makeService.AddMake(make);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
        [HttpGet("Makes")]
        public Object GetMakes()
        {
            var makes = _makeService.GetMakes();
            return JsonConvert.SerializeObject(makes, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );
        }
    }
}
