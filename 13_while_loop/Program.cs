using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your target");
        int target= int.Parse(Console.ReadLine());
        int start= 0;

        while(start<=target)
        {
            Console.Write(start + " ");
            start += 2;
        }
    }
}