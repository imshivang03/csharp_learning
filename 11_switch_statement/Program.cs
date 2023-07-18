using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number");
        int UserNum= int.Parse(Console.ReadLine());

        switch (UserNum)
        {
            /*
            case 10:
                Console.WriteLine("Entered number is 10");
                break;
            case 20:
                Console.WriteLine("Entered number is 20");
                break;
            case 30:
                Console.WriteLine("Entered number is 30");
                break;
            default:
                Console.WriteLine("The number entered is not 10, 20 & 30");
                break;
            */


            // we can also write the above programm as:
            case 10:
            case 20:
            case 30:
                Console.WriteLine("Entered number is {0}", UserNum);
                break;
            default:
                Console.WriteLine("The number entered is not 10, 20 & 30");
                break;
        }
    }
}