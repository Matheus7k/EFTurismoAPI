﻿namespace EFTurismoAPI.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Neighbothood { get; set; }
        public string CEP { get; set; }
        public string Complement { get; set; }
        public City City { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
