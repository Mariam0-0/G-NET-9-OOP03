using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_9_OOP03
{
    internal class StandardTicket : Ticket
    {
        //a.StandardTicket — adds SeatNumber(string).


        public string SeatNumber { get; set; }
        public StandardTicket(string movieName, double price, string seatNum) : base(movieName, price)
        {
            SeatNumber = seatNum;
        }
        public override string ToString()
        {
            return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax} EGP | Seat: {SeatNumber} ";
        }

    }
}
