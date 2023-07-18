using System;

class Program
{
    static void Main()
    {
        int TotalCoffeeCost= 0;
        
        // start is a label
        Start:
        Console.WriteLine("Please select your coffee - 1 - small, 2 - medium, 3 - large ");
        int UserChoice= int.Parse(Console.ReadLine());

        switch (UserChoice)
        {
            case 1:
                TotalCoffeeCost+=1;
                break;
            case 2:
                TotalCoffeeCost+=2;
                break;
            case 3:
                TotalCoffeeCost+=3;
                break;
            default:
                Console.WriteLine("Your choice {0} is invalid, please re-enter your choice", UserChoice);
                goto Start;
        }

        // decide is a label
        Decide:
        Console.WriteLine("Do you want to buy another coffee: Yes or No?");
        string UserDecision= Console.ReadLine();

        switch (UserDecision.ToUpper())
        {
            case "YES":
                goto Start;
            case "NO":
                break;
            default:
                Console.WriteLine("You have entered the wrong choice, Please re-enter");
                goto Decide;
        } 

        Console.WriteLine("Thanks for shopping with us, We want to see you again!");
        Console.WriteLine("Total Coffee cost is {0}", TotalCoffeeCost);
    }
}