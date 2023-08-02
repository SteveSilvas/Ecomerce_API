using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ecomerce.Model
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public int CityId { get; set; }
        public virtual AddressCity City { get; set; }
        public int StateId { get; set; }
        public virtual AddressState State { get; set; }
        public string ZipCode { get; set; }
        public string? Country { get; set; }
    }
}
