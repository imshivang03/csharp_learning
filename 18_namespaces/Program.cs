using System;
using PATA= ProjectA.TeamA;
using PATB= ProjectA.TeamB;

class Program
{
    static void Main()
    {
        PATA.ClassA.Print();
        PATB.ClassA.Print();

        // we can run the program by 2 ways these below 2 codes are running by giving whole name
        // 2nd and 3rd line of the code needs to be commented for running using the below 2 lines
        // ProjectA.TeamA.ClassA.Print();
        // ProjectA.TeamB.ClassA.Print();
    }
}

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team A print method");
            }
        }
    }
}

namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("Team B print method");
            }
        }
    }
}