using System;

class Program
{
    static void Main()
    {
        // by default value types are not nullable, value types are int, float, double, bool, structs, enums etc
        // by default reference types are nullable, reference types are string, interface, class, delegates, arrays etc
        // we use null for boolean in database to check if the user has entered anything (true, false) or not 
        
        
        bool? AreYouMajor= null;

        if (AreYouMajor == true)
        {
            Console.WriteLine("The user is Major");
        }

        else if (AreYouMajor == false)
        {
            Console.WriteLine("The user is minor");
        }
        else
        {
            Console.WriteLine("The user didn't enter any value");
        }
        
    }
}