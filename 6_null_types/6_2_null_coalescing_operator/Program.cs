// Program to check the tickets are available or not

using System;

class Program
{
    static void Main()
    {
        // using nullable types
        /*
        int? TicketsOnSale= null;
        int AvailableTickets;

        if (TicketsOnSale== null)
        {
            AvailableTickets= 0;
        }
        else 
        {
            // we can't directly assign the nullable data type value to the non nullable data type 
            // in order to do that we need to typecast 
            // both these below lines can type cast nullable to non nullable
            AvailableTickets= (int)TicketsOnSale;
            // AvailableTickets= TicketsOnSale.Value;
        }

        Console.WriteLine("Available tickets: {0}", AvailableTickets);
        */


        // using null coalescing operator
        int? TicketsOnSale= 100;
        int AvailableTickets= TicketsOnSale ?? 0;

        Console.WriteLine("Available Tickets: {0}", AvailableTickets);
    }
}