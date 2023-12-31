﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Ecomerce.Model
{
    public class Delivery
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool Status { get; set; }
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }

    }
}
