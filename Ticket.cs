using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_9_OOP03
{
    internal class Ticket
    {
        #region Requirments
        //1. Create a base class Ticket with:
        //a.MovieName(string), Price(decimal, must be > 0), TicketId(int, read-only, auto-incremented).
        //b.A constructor that takes movieName and price.
        //c.A computed property PriceAfterTax that returns the price with 14% tax.
        //d.Override ToString() to return the ticket info.
        //e.A static int GetTotalTickets() method that returns the total number of tickets created.


        #endregion

        #region 01


        private string _movieName;
        public string MovieName 
        {
            get { return _movieName; }
            set 
            { 
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Movie Name cannot be null or empty");
                    return;
                }
                _movieName = value;
            } 
        }

        private double _price;
        public double Price
        {
            get { return _price; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Price must be > 0");
                    return;
                }
                _price = value;
            }
        }

        private static int ticketCounter = 0;
        private int _ticketId;
        public int TicketId
        {
            get { return _ticketId; }
        }

        #endregion

        #region 02

        public Ticket(string movieName, double price)
        {
            MovieName = movieName;
            Price = price;
            _ticketId = ++ticketCounter;
        }
        #endregion

        #region 03

        public double PriceAfterTax
        {
            get { return _price + _price * 0.14; }
        }
        #endregion

        #region 04
        public override string ToString()
        {
            return $"Ticket #{_ticketId} | {MovieName} | Price: {Price} | After Tax: {PriceAfterTax}";
        }
        #endregion

      
        public static int GetTotalTicketsSold()
        {
            return ticketCounter;
        }



    }
}
