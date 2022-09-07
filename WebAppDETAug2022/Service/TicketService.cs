using System.Xml.Linq;
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.RazorPagesPizza
{
    public static class TicketService
    {
        static List<Ticket> Tickets { get; }
        static int nextId = 3;
        static TicketService()
        {
            Tickets = new List<Ticket>
            {
                new Ticket{ Id=1,Category="PlatinumPlus", Price=5000, MaxLimit=20000},
                new Ticket{ Id=2, Category="Platinum", Price=4000, MaxLimit=30000},
                new Ticket{Id=3, Category="Gold", Price=3000, MaxLimit=50000},
                 new Ticket{Id=4, Category="Silver", Price=2000, MaxLimit=50000},
                  new Ticket{Id=5, Category="General", Price=800, MaxLimit=100000},
            };
        }

        public static List<Ticket> GetAll() => Tickets;

        public static Ticket? Get(int id) => Tickets.FirstOrDefault(t => t.Id == id);

        public static void Add(Ticket Ticket)
        {
            Ticket.Id = nextId++;
            Tickets.Add(Ticket);
        }

        public static void Delete(int id)
        {
           var ticket = Get(id);
            if (ticket is null)
                return;

            Tickets.Remove(ticket);
        }

        public static void Update(Ticket ticket)
        {
            int index = Tickets.IndexOf(ticket);
            if (index == -1)
                return;

            Tickets[index] = ticket;
        }
    }
}
