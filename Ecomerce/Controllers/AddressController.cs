using Ecomerce.DTO;
using Ecomerce.Interface;
using Ecomerce.Model;
using Microsoft.AspNetCore.Mvc;

namespace Ecomerce.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _iAddressService;

        public AddressController(IAddressService iAddressService)
        {
            _iAddressService = iAddressService;
        }

        [HttpGet]
        public ResultDTO<IEnumerable<Address>> GetAllAddresses()
        {
            return _iAddressService.GetAll();
        }

        [HttpGet]
        public ResultDTO<Address> GetAddressById(int Id)
        {
            return _iAddressService.GetById(Id);
        }

        [HttpPost]
        public ActionResult AddAddress(Address address)
        {
            var result = _iAddressService.Insert(address);
            return result.ResultCode == 0 ? (ActionResult)Ok("Endereço registrado com sucesso.") : BadRequest();
        }

        [HttpPut]
        public ActionResult EditAddress(Address address)
        {
            var result = _iAddressService.Update(address);
            return result.ResultCode == 0 ? (ActionResult)Ok("Endereço Alterado com sucesso.") : BadRequest();
        }

        [HttpDelete]
        public ActionResult DeleteAddress(int addressId)
        {
            var result = _iAddressService.Delete(addressId);
            return result.ResultCode == 0 ? (ActionResult)Ok("Registro removido com sucesso.") : NotFound("Não encontrado.");
        }
    }
}
