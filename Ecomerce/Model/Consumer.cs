using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ecomerce.Model
{
    public class Consumer : User
    {
        public string compra { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }
    }
}
