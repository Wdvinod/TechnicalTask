using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechnicalTask.Data.Models;
using TechnicalTask.Service.Interface;

namespace TechnicalTask.UnitTest.Service
{
    public class MakeServiceFake : IMake
    {
        private readonly List<Make> makes = new List<Make>();
        public MakeServiceFake()
        {
            makes.Add(new Make()
            {
                Name = "Test item1"
            }
            );
            makes.Add(new Make()
            {
                Name = "Test item2"
            }
            );

        }
        public Task<Make> AddMake(Make make)
        {
            makes.Add(make);
            make.Id = makes.Count;
            return new Task<Make>(() => make);
        }
        public IEnumerable<Make> GetMakes()
        {
            return makes;
        }
    }
}
