﻿using Ecomerce.Model;

namespace Ecomerce.DTO
{
    public class AddressDTO
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string Complement { get; set; }
        public int CityId { get; set; }
        public int StateId { get; set; }
        public int ZipCode { get; set; }
        public string? Country { get; set; }
    }
}
