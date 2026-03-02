using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_9_OOP03
{
    internal class VIPTicket : Ticket
    {
        //b.VIPTicket — adds LoungeAccess(bool) and ServiceFee(decimal) = 50.
        public bool LoungeAccess { get; set; }

        private decimal _serviceFee = 50;
        public decimal ServiceFee 
        {
            get { return _serviceFee; }
        }
        public VIPTicket(string movieName, double price , bool loungeAccess) : base(movieName, price)
        {
            LoungeAccess = loungeAccess;
        }
        public override string ToString()
        {
            string access;
            if (LoungeAccess) access = "Yes";
            else access = "No";

            return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax} EGP | Lounge: {access} | Service Fee: {ServiceFee} EGP";
        }
    }
}
