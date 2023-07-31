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

        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            var result = _employeeService.Insert(employee);
            return result.ResultCode == 0 ? (ActionResult)Ok() : BadRequest();
        }

        [HttpPost]
        public ActionResult EditEmployee(Employee employee)
        {
            var result = _employeeService.Update(employee);
            return result.ResultCode == 0 ? (ActionResult)Ok() : BadRequest();
        }

        [HttpPost]
        public ActionResult Delete(int employeeId)
        {
            var result = _employeeService.Delete(employeeId);
            return result.ResultCode == 0 ? (ActionResult)Ok() : NotFound();
        }
    }
}
