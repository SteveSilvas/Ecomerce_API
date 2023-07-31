using Ecomerce.DTO;
using Ecomerce.Interface;
using Ecomerce.Model;
using System.Collections.Generic;

namespace Ecomerce.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _iEmployeeRepository;

        public EmployeeService(IEmployeeRepository iEmployeeRepository)
        {
            _iEmployeeRepository = iEmployeeRepository;
        }

        public ResultDTO<IEnumerable<Employee>> GetAll()
        {
            var employees = _iEmployeeRepository.GetAll();
            if (employees != null)
            {
                return new ResultDTO<IEnumerable<Employee>>(0, "Sucesso.", employees);
            }
            else
            {
                return new ResultDTO<IEnumerable<Employee>>(1, "No employees found.", null);
            }
        }

        public ResultDTO<Employee> GetById(int employeeId)
        {
            var employee = _iEmployeeRepository.GetById(employeeId);
            if (employee != null)
            {
                return new ResultDTO<Employee>(0, "Sucesso.", employee);
            }
            else
            {
                return new ResultDTO<Employee>(1,"Employee not found.", null);
            }
        }

        public ResponseDTO Insert(Employee employee)
        {
            _iEmployeeRepository.Insert(employee);
            return new ResponseDTO(0, "Sucesso.");
        }

        public ResponseDTO Update(Employee employee)
        {
            _iEmployeeRepository.Update(employee);
            return new ResponseDTO(0, "Sucesso.");
        }

        public ResponseDTO Delete(int employeeId)
        {
            var employee = _iEmployeeRepository.GetById(employeeId);
            if (employee != null)
            {
                _iEmployeeRepository.Delete(employeeId);
                return new ResponseDTO(0, "Sucesso.");
            }
            else
            {
                return new ResponseDTO(1, "Employee not found.");
            }
        }

        public ResponseDTO Save()
        {
            try
            {
                _iEmployeeRepository.Save();
                return new ResponseDTO(0, "Sucesso.");
            }
            catch {
                return new ResponseDTO(1, "Erro.");
            }
        }
    }
}
