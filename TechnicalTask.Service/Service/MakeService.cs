using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechnicalTask.Data.Models;
using TechnicalTask.Data.Repository;
using TechnicalTask.Service.Interface;

namespace TechnicalTask.Service.Service
{
    public class MakeService : IMake
    {
        private readonly IRepository<Make> _make;

        public MakeService(IRepository<Make> make)
        {
            _make = make;
        }
        public async Task<Make> AddMake(Make make)
        {
            return await _make.Create(make);
        }
        public IEnumerable<Make> GetMakes()
        {
            return _make.GetAll();
        }
    }
}
