namespace EFTurismoAPI.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public Address? Origin { get; set; }
        public Address? Destination { get; set; }
        public Client Client { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
    }
}