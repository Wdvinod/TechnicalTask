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
    public class VehicleTypeController : ControllerBase
    {
        private readonly IVehicleType _vehicleTypeService;
        public VehicleTypeController(IVehicleType vehicleTypeService)
        {
            _vehicleTypeService = vehicleTypeService;
        }
         
        [HttpPost("VehicleType")]
        public async Task<VehicleType> AddVehicleType([FromBody] VehicleType vehicleType)
        {
            try
            {
                return await _vehicleTypeService.AddVehicleType(vehicleType);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        [HttpGet("VehicleType")]
        public Object GetVehicleTypes()
        {
            var vehicleTypes = _vehicleTypeService.GetVehicleTypes();
            return JsonConvert.SerializeObject(vehicleTypes, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                }
            );
        }
    }
}
