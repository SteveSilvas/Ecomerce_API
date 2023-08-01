using Ecomerce.DTO;
using Ecomerce.Interface;
using Ecomerce.Model;
using Microsoft.AspNetCore.Mvc;

namespace Ecomerce.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        public ResultDTO<IEnumerable<DepartmentDTO>> GetAllDepartments()
        {
            return _departmentService.GetAll();
        }

        [HttpGet]
        public ResultDTO<DepartmentDTO> GetDepartmentByID(int departmentId)
        {
            return _departmentService.GetById(departmentId);
        }

        [HttpPost]
        public ActionResult AddDepartment(DepartmentDTO department)
        {
            var result = _departmentService.Insert(department);
            return result.ResultCode == 0 ? (ActionResult)Ok("Departamento Criado com sucesso.") : BadRequest();
        }

        [HttpPut]
        public ActionResult EditDepartment(DepartmentDTO department)
        {
            var result = _departmentService.Update(department);
            return result.ResultCode == 0 ? (ActionResult)Ok("Departamento Alterado com sucesso.") : BadRequest();
        }

        [HttpDelete]
        public ActionResult DeleteDepartment(int departmentId)
        {
            var result = _departmentService.Delete(departmentId);
            return result.ResultCode == 0 ? (ActionResult)Ok("Registro removido com sucesso.") : NotFound("Não encontrado.");
        }
    }
}
