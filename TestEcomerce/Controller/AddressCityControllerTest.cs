using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecomerce.Controllers;
using Ecomerce.DTO;
using Ecomerce.Interface;
using Ecomerce.Model;
using Moq;
using TestEcomerce.Mocks;

namespace TestEcomerce.Controller
{
    public class AddressCityControllerTest
    {
        private AddressCityController _controller;
        private IAddressCityService _addressCityServiceMock;

        [SetUp]
        public void Setup()
        {
            _addressCityServiceMock = AddressCityServiceMock.Create();
            _controller = new AddressCityController(_addressCityServiceMock);
        }

        [Test]
        public void GetAllCities_ReturnsListOfCities()
        {
            // Arrange
            ResultDTO<IEnumerable<AddressCity>> expected = new ResultDTO<IEnumerable<AddressCity>>(0, "Success.", AddressCityMock.GetCities());

            // Act
            ResultDTO<IEnumerable<AddressCity>> actual = _controller.GetAllCities();

            // Assert
            Assert.AreEqual(expected.ResultCode, actual.ResultCode);
            Assert.AreEqual(expected.ResultMessage, actual.ResultMessage);
            Assert.AreEqual(expected.Data, actual.Data);
        }

        [Test]
        public void GetCityById_ReturnOneCityById()
        {
            ResultDTO<AddressCity> expected = new ResultDTO<AddressCity>(0, "Success.",AddressCityMock.GetCity(2));

            ResultDTO<AddressCity> resultController = _controller.GetCityById(2);

            Assert.AreEqual(expected.ResultCode, resultController.ResultCode);
            Assert.AreEqual(expected.ResultMessage, resultController.ResultMessage);
            //Assert.That(resultController.Data, Is.EqualTo(expected.Data));

        }


    }
}
