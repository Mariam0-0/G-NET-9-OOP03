using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_9_OOP03
{
    internal class IMAXTicket : Ticket
    {
        //c.IMAXTicket — adds Is3D(bool). If true, the price increases by 30 EGP.

        public bool Is3D {  get; set; }
        public IMAXTicket(string movieName, double price, bool is3d) : base(movieName, price)
        {
            Is3D = is3d;
            if (is3d) 
            {
                price += 30;
            }
        }
        public override string ToString()
        {
            string is3d;
            if (Is3D) is3d = "Yes";
            else is3d = "No";
            return $"Ticket #{TicketId} | {MovieName} | Price: {Price} EGP | After Tax: {PriceAfterTax} EGP | IMAX 3D: {is3d} ";
        }
    }
}
