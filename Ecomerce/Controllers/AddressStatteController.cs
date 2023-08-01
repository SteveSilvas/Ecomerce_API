using Ecomerce.DTO;
using Ecomerce.Interface;
using Ecomerce.Model;
using Microsoft.AspNetCore.Mvc;

namespace Ecomerce.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class AddressStateController : ControllerBase
    {
        private readonly IAddressStateService _iAddressStateService;

        public AddressStateController(IAddressStateService iAddressStateService)
        {
            _iAddressStateService = iAddressStateService;
        }

        [HttpGet]
        public ResultDTO<IEnumerable<AddressState>> GetAllStates()
        {
            return _iAddressStateService.GetAll();
        }

        [HttpGet]
        public ResultDTO<AddressState> GetStateById(int stateId)
        {
            return _iAddressStateService.GetById(stateId);
        }

        [HttpPost]
        public ActionResult AddState(AddressState state)
        {
            var result = _iAddressStateService.Insert(state);
            return result.ResultCode == 0 ? (ActionResult)Ok("Estado registrado com sucesso.") : BadRequest();
        }

        [HttpPut]
        public ActionResult EditState(AddressState State)
        {
            var result = _iAddressStateService.Update(State);
            return result.ResultCode == 0 ? (ActionResult)Ok("Estado Alterado com sucesso.") : BadRequest();
        }

        [HttpDelete]
        public ActionResult DeleteState(int StateId)
        {
            var result = _iAddressStateService.Delete(StateId);
            return result.ResultCode == 0 ? (ActionResult)Ok("Registro removido com sucesso.") : NotFound("Não encontrado.");
        }
    }
}
