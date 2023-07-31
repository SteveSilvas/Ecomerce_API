using System.Globalization;

namespace Ecomerce.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Sexo { get; set; }
        public decimal Salario { get; set; }
        public string? Department { get; set; }  
    }
}
