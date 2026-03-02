using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_9_OOP03

{
    internal class Cinema
    {

        #region Requirments
        //3. Create a Cinema class that has a CinemaName, a Projector object (created inside Cinema), and holds up to 20 tickets.Add:
        //a.AddTicket(Ticket t) — adds a ticket to the first available slot.
        //b.PrintAllTickets() — prints all tickets.
        //c.OpenCinema() and CloseCinema() — start/stop the projector.

        #endregion

        public string CinemaName { get; set; }
        public Projector projector = new Projector();


        private Ticket[] tickets = new Ticket[20];

        public void OpenCinema()
        {
            Console.WriteLine("======= Cinema Opened =======");
        }

        public void CloseCinema()
        {
            Console.WriteLine("======= Cinema Closed =======");
        }

        public void StartProjector()
        {
            projector.Start();
        }

        public void StopProjector()
        {
            projector.Stop();
        }

        public bool AddTicket(Ticket t)
        {
            for (int i = 0; i < 20; i++)
            {
                if (tickets[i] == null)
                {
                    tickets[i] = t;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllTickets()
        {
            Console.WriteLine("======= All Tickets =======");
            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i] != null)
                {
                    Console.WriteLine(tickets[i]);
                }
                else
                    continue;
            }

        }
        
    }
}

