using Ecomerce.DTO;
using Ecomerce.Interface;
using Ecomerce.Model;
using Microsoft.AspNetCore.Mvc;

namespace Ecomerce.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AddressCityController : ControllerBase
    {
        private readonly IAddressCityService _iAddressCityService;

        public AddressCityController(IAddressCityService iAddressCityService)
        {
            _iAddressCityService = iAddressCityService;
        }

        [HttpGet]
        public ResultDTO<IEnumerable<AddressCity>> GetAllCities()
        {
            return _iAddressCityService.GetAll();
        }

        [HttpGet]
        public ResultDTO<AddressCity> GetCityById(int cityId)
        {
            return _iAddressCityService.GetById(cityId);
        }

        [HttpPost]
        public ResponseDTO AddCity(AddressCity city)
        {
            return _iAddressCityService.Insert(city);
        }

        [HttpPut]
        public ResponseDTO EditCity(AddressCity city)
        {
            return _iAddressCityService.Update(city);
        }

        [HttpDelete]
        public ResponseDTO DeleteCity(int cityId)
        {
            return _iAddressCityService.Delete(cityId);
        }
    }
}
