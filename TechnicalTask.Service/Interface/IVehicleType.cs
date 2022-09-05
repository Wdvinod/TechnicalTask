using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechnicalTask.Data.Models;

namespace TechnicalTask.Service.Interface
{
    public interface IVehicleType
    {
        public Task<VehicleType> AddVehicleType(VehicleType vehicleType);
        public IEnumerable<VehicleType> GetVehicleTypes();
    }
}
