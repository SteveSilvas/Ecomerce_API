using Ecomerce.Interface;
using Ecomerce.Model;

namespace Ecomerce.Services
{
    public class EmployeeAdd
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeAdd(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public void ValidateFields(Employee employee)
        {
            throw new NotImplementedException();    
        }
    }
}
