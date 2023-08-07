using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Ecomerce.Model
{
    public class Employee : User
    {
        public decimal Salario { get; set; }
        public DateTime Admission { get; set; }
        public DateTime? Resignation { get; set; }
        public bool Active { get; set; } = true;
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
