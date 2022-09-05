using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechnicalTask.Data.Models;
using TechnicalTask.Data.Repository;
using TechnicalTask.Service.Interface;

namespace TechnicalTask.Service.Service
{
    public class VehicleTypeService : IVehicleType
    {
        private readonly IRepository<VehicleType> _vehicleType;

        public VehicleTypeService(IRepository<VehicleType> make)
        {
            _vehicleType = make;
        }
        public async Task<VehicleType> AddVehicleType(VehicleType make)
        {
            return await _vehicleType.Create(make);
        }
        public IEnumerable<VehicleType> GetVehicleTypes()
        {
            return _vehicleType.GetAll();
        }
    }
}
