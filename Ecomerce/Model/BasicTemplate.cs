using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ecomerce.Model
{
    public class BasicTemplate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string? Description { get; set; }

        public BasicTemplate() { }
        public BasicTemplate(int id, string description) {
            Id = id;
            Description = description;
        }
    }
}
