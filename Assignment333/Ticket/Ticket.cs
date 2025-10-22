using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Enum for TicketType
public enum TicketType
{
    Regular,
    VIP,
    Backstage
}

namespace Assignment333.Ticket
{
    public class Tickett
    {
        //Propertis
        public string EventName { get; set; }
        public string SeatNumber { get; set; }
        public TicketType Type { get; set; }

        //Constructor
        public Tickett(string eventName, string seatNumber, TicketType type)
        {
            EventName = eventName;
            SeatNumber = seatNumber;
            Type = type;
        }
    }
    // TicketSystem class with indexer
    public class TicketSystem
    {
        private List<Tickett> tickets = new List<Tickett>();

        // Add ticket to the system
        public void AddTicket(Tickett ticket)
        {
            tickets.Add(ticket);
        }

        // Indexer to access ticket by seat number
        public Tickett this[string seatNumber]
        {
            get
            {
                return tickets.Find(t => t.SeatNumber == seatNumber);
            }
        }

        // Method to count tickets by type
        public void CountTicketsByType()
        {
            int regular = 0, vip = 0, backstage = 0;

            foreach (var ticket in tickets)
            {
                switch (ticket.Type)
                {
                    case TicketType.Regular: regular++; break;
                    case TicketType.VIP: vip++; break;
                    case TicketType.Backstage: backstage++; break;
                }
            }

            Console.WriteLine($"Regular: {regular}, VIP: {vip}, Backstage: {backstage}");
        }
    }
}
