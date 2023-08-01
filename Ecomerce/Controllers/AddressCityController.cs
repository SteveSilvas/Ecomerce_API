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
        public ActionResult AddCity(AddressCity city)
        {
            var result = _iAddressCityService.Insert(city);
            return result.ResultCode == 0 ? (ActionResult)Ok("Cidade registrada com sucesso.") : BadRequest();
        }

        [HttpPut]
        public ActionResult EditCity(AddressCity city)
        {
            var result = _iAddressCityService.Update(city);
            return result.ResultCode == 0 ? (ActionResult)Ok("Cidade Alterada com sucesso.") : BadRequest();
        }

        [HttpDelete]
        public ActionResult DeleteCity(int cityId)
        {
            var result = _iAddressCityService.Delete(cityId);
            return result.ResultCode == 0 ? (ActionResult)Ok("Registro removido com sucesso.") : NotFound("Não encontrado.");
        }
    }
}
