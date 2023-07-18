using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int UserNumber= int.Parse(Console.ReadLine());
        
        /*
        if (UserNumber==1)
        {
            Console.WriteLine("Entered number is 1");
        }
        else if (UserNumber==2)
        {
            Console.WriteLine("Entered number is 2");
        }
        else if (UserNumber==3)
        {
            Console.WriteLine("Entered number is 3");
        }
        else
        {
            Console.WriteLine("Entered number is not between 1 and 3");
        }
        */


        /*
        // OR condition (|| / |) : it will execute if any one condition is true 
        // || : if the first condition is true then it won't check the other condition.
        // | : regardless of the first condition is true, it will check for other condition as well
        // | increse the time complexity
        if (UserNumber==10 || UserNumber==20)
        {
            Console.WriteLine("Entered number is either 10 or 20");
        }
        else
        {
            Console.WriteLine("Entered number is neither 10 nor 20");
        }
        */


        // AND operator (&& / &) : it will execute if both the conditions are true 
        // && : if the first condition is false then it won't check the other condition.
        // | : regardless of the first condition is false, it will check for other condition as well
        // | increse the time complexity
        if (UserNumber==10 && UserNumber==20)
        {
            Console.WriteLine("Entered number is either 10 or 20");
        }
        else
        {
            Console.WriteLine("Entered number is neither 10 nor 20");
        }
    }
}