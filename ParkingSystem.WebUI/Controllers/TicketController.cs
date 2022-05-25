using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using ParkingSystem.WebUI.Models;
using ParkingSystem.WebUI.Service;

namespace ParkingSystem.WebUI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TicketController : Controller
    {
        private readonly ILogger<TicketController> _logger;
        public IConfiguration _configuration;
        public TicketController(ILogger<TicketController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet]
        public int Get()
        {
            TicketService service = new TicketService(_configuration);
            return service.GetTicket();
        }

        [HttpPost]
        public void MakePayment([FromBody] TicketPayment ticketPayment)
        {
            TicketService service = new TicketService(_configuration);
            service.MakePayment(ticketPayment);
        }
    }
}
