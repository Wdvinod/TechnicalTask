using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TechnicalTask.Controllers;
using TechnicalTask.Data.Models;
using TechnicalTask.Service.Interface;
using TechnicalTask.UnitTest.Service;
using Xunit;
using System.Linq;

namespace TechnicalTask.UnitTest.Tests
{
    public class MakeControllerTest
    {

        private readonly MakeController _controller;
        private readonly IMake _service;
        public MakeControllerTest()
        {
            _service = new MakeServiceFake();
            _controller = new MakeController(_service);
        }

        [Fact]
        public void Add_ValidObjectPassed_ReturnsCreatedObject()
        {
            // Arrange
            Make testItem = new Make()
            {
                Name = "Testing add item"
            };
            // Act
            var createdResponse = _controller.AddMake(testItem);
            // Assert
            Assert.NotEqual(0, createdResponse.Id);
        }
        [Fact]
        public void Get_WhenCalled_ReturnsAllItems()
        {

            // Act
            var result = _controller.GetMakes();
            // Assert
            var items  = (JsonConvert.DeserializeObject<List<Make>>(result.ToString()));
            Assert.Equal(2, items.Count);
        }
    }
}
