using AutoMapper;
using Ecomerce.DTO;
using Ecomerce.Interface;
using Ecomerce.Model;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEcomerce.Mocks
{
    public class AddressCityServiceMock
    {
        public static IAddressCityService Create()
        {
            var mapperMock = new Mock<IMapper>();
            var serviceMock = new Mock<IAddressCityService>();

            IEnumerable<AddressCity> addresses = AddressCityMock.GetCities();
            AddressCity address = AddressCityMock.GetCity(1);

            serviceMock.Setup(service => 
                service.GetAll()).Returns(new ResultDTO<IEnumerable<AddressCity>>(0, "Success.", addresses));

            serviceMock.Setup(service => 
                service.GetById(It.IsAny<int>())).Returns(new ResultDTO<AddressCity>(0, "Success.", address));

            serviceMock.Setup(service => 
                service.Insert(It.IsAny<AddressCity>())).Returns(new ResponseDTO(0, "Cidade cadastrada com Sucesso."));

            serviceMock.Setup(service => 
             service.Update(It.IsAny<AddressCity>())).Returns(new ResponseDTO(0, "Cidade alterada com Sucesso."));

            serviceMock.Setup(service => 
                service.Delete(It.IsAny<int>())).Returns(new ResponseDTO(0, "Sucesso."));

            return serviceMock.Object;
        }
    }
}
