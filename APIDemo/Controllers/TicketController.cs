using APIDemo.Models;
using APIDemo.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        [HttpGet]
        [Route("all")]
        public List<Ticket>Get()
        {
            return TicketService.GetAll();

        }
        [HttpGet]
        [Route("{ID}")]
        public Ticket Get(int ID)
        {
            Ticket t = TicketService.Get(ID);
            return t;
        }
    }
}
