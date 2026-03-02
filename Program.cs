using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Net.Sockets;
using System.Reflection.Metadata;
using System.Security.Principal;

namespace G_NET_9_OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01: Theoretical Questions

            //Part 01 : Theoretical Questions

            #region Question 01

            // ===============================================================================
            //Q1: Identify the type of relationship in each scenario below(Inheritance, Association, Aggregation, Composition, or Dependency):

            //a) A University has Departments. If the university is closed, the departments no longer exist.
            //b) A Driver uses a Car.The driver does not own the car.
            //c) A Dog is an Animal.
            //d) A Team has Players. If the team is deleted, the players still exist.
            //e) A method receives a Logger as a parameter and calls it inside the method only.
            // ===============================================================================

            //a) A University has Departments. If the university is closed, the departments no longer exist.

            // Composition relationship since this is a HAS-A strong relationship

            // ===============================================================================
            //b) A Driver uses a Car.The driver does not own the car.

            // Association relationship 

            // ===============================================================================
            //c) A Dog is an Animal.

            // Inheritance relationship, since this is a IS-A relationship

            // ===============================================================================
            //d) A Team has Players. If the team is deleted, the players still exist.

            // Aggregation relationship, since this is a weak HAS-A relationship

            // ===============================================================================
            //e) A method receives a Logger as a parameter and calls it inside the method only.

            // Dependency relationship, since the class object is used as a parameter in a function

            #endregion

            #region Question 02

            // ===============================================================================
            //Q2: Answer the following questions about access modifiers and sealed:

            //a) A parent class has a protected field.Can a child class in a different assembly access it? What about through an object instance from outside?
            //b) What is the difference between protected internal and private protected?
            //c) What does the sealed keyword do when applied to a class? What about when applied to a method?
            //d) Can you create an object from a sealed class using new? Why or why not?
            // ===============================================================================


            // a)

            // If a field is protected => it is accessible for any child class in that assembly or in a different one
            // For an object instance from outside it won't be accessible, without inheritance protected is treated as private

            // ===============================================================================
            // b)

            // WITHOUT INHERITANCE:
            // protected internal => member is accessible in the same assembly since it's "internal"
            // private protected  => member is accessible in the same class since it's "private"

            // WITH INHERITANCE:
            // protected internal => accessible in the same assembly (like internal), or in child classes anywhere (like protected)
            // private protected  => accessible in its own class (like private), or in child classes anywhere (like protected)


            // ===============================================================================
            // c) What does the sealed keyword do when applied to a class? What about when applied to a method?

            // when it's applied to a class => means that this class cannot be inherited (the class is the final class in its hierarchy)
            // when it's applied to a method => means that this method cannot be overridden by child classes (final form of this method)



            // ===============================================================================
            // d) Can you create an object from a sealed class using new? Why or why not?

            // yes because class sealing prevents inheritance not instantiation 


            #endregion

            #endregion

            #region Part 02: Practical

            #region Requirements


            // ===============================================================================
            //Part 02 : Practical(Extending the Movie Ticket Booking System)
            //In Assignments 01 & 02, you built a Movie Ticket Booking System with a Ticket class, properties, indexers, and static members.Now you will refactor and extend it using inheritance, composition, and sealed classes.
            //What you need to build :

            //1. Create a base class Ticket with:
            //a.MovieName(string), Price(decimal, must be > 0), TicketId(int, read-only, auto-incremented).
            //b.A constructor that takes movieName and price.
            //c.A computed property PriceAfterTax that returns the price with 14% tax.
            //d.Override ToString() to return the ticket info.
            //e.A static int GetTotalTickets() method that returns the total number of tickets created.


            //2. Create three child classes that inherit from Ticket:
            //a.StandardTicket — adds SeatNumber(string).
            //b.VIPTicket — adds LoungeAccess(bool) and ServiceFee(decimal) = 50.
            //c.IMAXTicket — adds Is3D(bool). If true, the price increases by 30 EGP.
            //Each child class should override ToString() to include its own extra info.


            //3. Create a Cinema class that has a CinemaName, a Projector object (created inside Cinema), and holds up to 20 tickets.Add:
            //a.AddTicket(Ticket t) — adds a ticket to the first available slot.
            //b.PrintAllTickets() — prints all tickets.
            //c.OpenCinema() and CloseCinema() — start/stop the projector.

            //4. In Main, do the following:
            //a.Create a Cinema and open it.
            //b.Create one of each ticket type (hardcoded data) and add them to the Cinema.
            //c.Print all tickets.
            //d.Close the Cinema.
            // ===============================================================================
            #endregion



            #region Main

            //Cinema cinema = new Cinema();
            //Ticket ticket1 = new StandardTicket("Inception", 120, "A-5");
            //Ticket ticket2 = new VIPTicket("Avengers", 200, true);
            //Ticket ticket3 = new IMAXTicket("Dune", 180, false);
            //cinema.AddTicket(ticket1);
            //cinema.AddTicket(ticket2);
            //cinema.AddTicket(ticket3);

            //cinema.OpenCinema();
            //cinema.StartProjector();
            //Console.WriteLine();

            //cinema.PrintAllTickets();
            //Console.WriteLine();

            //Console.WriteLine("========= Statistics =========");
            //Console.WriteLine($"Total tickets sold: {Ticket.GetTotalTicketsSold()}");
            //Console.WriteLine();
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine($"Booking Reference {i + 1}: {BookingHelper.GenerateBookingReference()}");
            //}

            //Console.WriteLine();
            //Console.WriteLine($"Group Discount (5 tickets x 100 EGP): {BookingHelper.CalcGroupDiscount(5, 100)} EGP (10% off applied)");

            //Console.WriteLine();
            //cinema.CloseCinema();
            //cinema.StopProjector();
            #endregion

            #endregion

        }
    }
}
