using Ecomerce.DTO;
using Ecomerce.Model;
using System.Data.Entity;

namespace Ecomerce.Interface
{
    public interface IEmployeeService
    {
        ResultDTO<IEnumerable<Employee>> GetAll();
        ResultDTO<Employee> GetById(int EmployeeID);
        ResponseDTO Insert(Employee employee);
        ResponseDTO Update(Employee employee);
        ResponseDTO Delete(int EmployeeID);
        ResponseDTO Save();
    }
}
