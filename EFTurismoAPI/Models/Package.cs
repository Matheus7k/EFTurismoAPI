namespace EFTurismoAPI.Models
{
    public class Package
    {
        public int Id { get; set; }
        public Hotel Hotel { get; set; }
        public Ticket Ticket { get; set; }
        public double Price { get; set; }
        public Client Client { get; set; }
        public DateTime DateCreated { get; set; }
    }
}