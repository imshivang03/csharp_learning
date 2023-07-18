using System;

class Program
{
    public static void Main()
    {
        Program.EvenNumbers(30);

        Program P= new Program();
        int Sum= P.Add(25, 25);
        Console.WriteLine("Sum = {0}", Sum);
    }

    public int Add(int Fn, int Sn)
    {
        return (Fn+Sn);
    }

    public static void EvenNumbers(int Target)
    {
        int Start= 0;
        while (Start<= Target)
        {
            Console.WriteLine(Start);
            Start +=2;
        } 
    }
}