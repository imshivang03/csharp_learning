using System;

class Program
{
    static void Main()
    {
        /*
        int[] Numbers= new int[3];
        Numbers[0]= 101;
        Numbers[1]= 102;
        Numbers[2]= 103;
        */

        /*
        // for loop
        int[] Numbers= {101, 102, 103};

        for (int i= 0; i<Numbers.Length; i++)
        {
            Console.WriteLine(Numbers[i]);
        }
        */


        /*
        // for each loop
        int[] Numbers= {101, 102, 103};
        foreach(int k in Numbers)
        {
            Console.WriteLine(k);
        }
        */

        // Using continue in for loop
        for (int i= 0; i<=20; i++)
        {
            if (i%2==1)
                continue;
            Console.WriteLine(i);
        }
    }
}