using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ecomerce.Model
{
    public class AddressCity : BasicTemplate
    {
        public AddressCity(int id, string description) : base(id, description)
        {
        }
    }
}
