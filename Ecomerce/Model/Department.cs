using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecomerce.Model
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
        public Department() { }
        public Department(int id, string name) 
        {
            Id = id;
            Name = name;
        }
    }
}
