using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using WebAppDETAug2022.Models;
using WebAppDETAug2022.RazorPagesPizza;

namespace WebAppDETAug2022.Pages
{
    public class IPLEventModel : PageModel
    {
        public List<Ticket> Tickets { get; set; }
        //public void OnGet()
        //{
        //    Tickets = new List<Ticket>
        //    {
        //        new Ticket{Category="PlatinumPlus", Price=5000, MaxLimit=20000},
        //        new Ticket{Category="Platinum", Price=4000, MaxLimit=30000},
        //        new Ticket{Category="Gold", Price=3000, MaxLimit=50000},
        //         new Ticket{Category="Silver", Price=2000, MaxLimit=50000},
        //          new Ticket{Category="General", Price=800, MaxLimit=100000},

        //    };
        //}
         public void OnGet()
        {
            Tickets = TicketService.GetAll();
        }
    }
}
