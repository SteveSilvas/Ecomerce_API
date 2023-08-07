using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ecomerce.Model
{
    public class Cart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ConsumerId { get; set; }
        public virtual Consumer Consumer { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set;}
    }
}
