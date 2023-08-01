namespace Ecomerce.DTO
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sexo { get; set; }
        public decimal Salario { get; set; }
        public DateTime Admission { get; set; } // Use string para receber a data no formato ISO 8601
        public DateTime Resignation { get; set; } // Use string para receber a data no formato ISO 8601
        public bool Active { get; set; }
        public int DepartmentId { get; set; }
    }
}
