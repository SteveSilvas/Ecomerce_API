using Ecomerce.DTO;
using Ecomerce.Model;
using System.Data.Entity;

namespace Ecomerce.Interface
{
    public interface IEmployeeService
    {
        ResultDTO<IEnumerable<Employee>> GetAll();
        ResultDTO<Employee> GetById(int EmployeeId);
        ResponseDTO Insert(EmployeeDTO employee);
        ResponseDTO Update(EmployeeDTO employee);
        ResponseDTO Delete(int EmployeeId);
        ResponseDTO Save();
    }
}
