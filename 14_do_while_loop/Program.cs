using System;

class Program
{
    static void Main()
    {
        string UserChoice= string.Empty;
        do
        {
            Console.WriteLine("Enter your target");
            int target= int.Parse(Console.ReadLine());

            int start= 0;
            while(start<=target)
            {
                Console.Write(start + " ");
                start += 2;
            }
        
            do
            {
                Console.WriteLine("Do you want to continue - yes or no");
                UserChoice= Console.ReadLine().ToUpper();

                if (UserChoice != "YES" && UserChoice != "NO")
                {
                    Console.WriteLine("choice is invalid, please try again");
                }
            } while (UserChoice!= "YES" && UserChoice!= "NO");
        } while (UserChoice == "YES");
    }
}