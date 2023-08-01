using Ecomerce.DTO;
using Ecomerce.Interface;
using Ecomerce.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Ecomerce.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public ResultDTO<IEnumerable<Employee>> GetAll()
        {
            return  _employeeService.GetAll();
        }

        [HttpGet]
        public ResultDTO<Employee> GetByID(int employeeId)
        {
            return _employeeService.GetById(employeeId);
        }

        [HttpPost]
        public ActionResult AddEmployee(EmployeeDTO employee)
        {
            var result = _employeeService.Insert(employee);
            return result.ResultCode == 0 ? (ActionResult)Ok("Employee Criado com sucesso.") : BadRequest();
        }

        [HttpPut]
        public ActionResult EditEmployee(EmployeeDTO employee)
        {
            var result = _employeeService.Update(employee);
            return result.ResultCode == 0 ? (ActionResult)Ok("Employee Alterado com sucesso.") : BadRequest();
        }

        [HttpDelete]
        public ActionResult Delete(int employeeId)
        {
            var result = _employeeService.Delete(employeeId);
            return result.ResultCode == 0 ? (ActionResult)Ok("Registro removido com sucesso.") : NotFound("Não encontrado.");
        }
    }
}
