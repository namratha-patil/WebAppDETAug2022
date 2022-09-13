using APIDemo.Models;

namespace APIDemo.Service
{
    public class TicketService
    {
        static List<Ticket> Tickets { get;}
        static TicketService()
        {

            Tickets = new List<Ticket>

            {
                new Ticket { ID = 1, BookedFor = "PlatinumPlus", Price = 5000, Qty = 200 },
                new Ticket { ID = 2, BookedFor = "Platinum", Price = 4000, Qty = 300 },
                new Ticket { ID = 3, BookedFor = "Gold", Price = 3000, Qty = 500 },
                new Ticket { ID = 4, BookedFor = "Silver", Price = 2000, Qty = 50 },
                new Ticket { ID = 5, BookedFor = "General", Price = 800, Qty = 10 },
            };

        }

        public static List<Ticket> GetAll() => Tickets;
         
        public static Ticket Get(int id)
        {
            Ticket ticket = Tickets.FirstOrDefault(x=>x.ID==id);
            return ticket;
        }
    }

}
