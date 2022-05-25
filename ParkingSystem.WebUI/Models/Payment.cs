using System.Collections.Generic;

namespace ParkingSystem.WebUI.Models
{
    public class TicketPayment
    {
        public int Id { get; set; }
        public byte CreditCardNumber { get; set; }    
        public List<Ticket> TicketId { get; set; }
    }
}
