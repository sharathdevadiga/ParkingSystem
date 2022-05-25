using Microsoft.Extensions.Configuration;
using ParkingSystem.WebUI.Models;
using System.Linq;

namespace ParkingSystem.WebUI.Service
{
    public class TicketService
    {
        public IConfiguration _configuration;
        public TicketService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public int GetTicket()
        {
            using (var context = new ParkingLotSystemContext(_configuration))
            {
                var ticketCount = context.Ticket.ToArray().Count();
                if(ticketCount != 500)
                {
                    ticketCount = ticketCount + 1;
                    context.Ticket.Add(new Ticket() { TicketNumber = ticketCount});
                    context.SaveChanges();
                    return ticketCount ;
                }
            }
            
            return 500;
        }
        public void MakePayment(TicketPayment payment)
        {
            using (var context = new ParkingLotSystemContext(_configuration))
            {
                context.TicketPayment.Add(payment);
                context.SaveChanges();
            }
           
        }
    }
}
