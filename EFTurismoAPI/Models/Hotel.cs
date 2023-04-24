namespace EFTurismoAPI.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public DateTime DateCreated { get; set; }
        public Double Price { get; set; }
    }
}
