using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ecomerce.Model
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price{ get; set; }
        public int CategoryId { get; set; }
        public virtual ProductCategory Category { get; set; }
        public virtual Stock Stock { get; set; }
    }
}
