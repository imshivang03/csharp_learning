using System;

//Parameter arrays
class Program
{
    public static void Main()
    {
        int[] Numbers= {1,2,3,4,5};
        ParamsMethod(Numbers);

    }

    public static void ParamsMethod(params int [] Numbers)
    {
        Console.WriteLine("The length of the array is {0}", Numbers.Length);
        foreach(int i in Numbers)
        {
            Console.WriteLine(i);
        }
    }
}

/*
// Out Parameters is used when we want to return more than one values.
class Program
{
    public static void Main()
    {
        int Total= 0;
        int Product= 0;
        Calculate(10, 20, out Total, out Product);
        Console.WriteLine("Sum = {0} && Product = {1}", Total, Product);
    }

    public static void Calculate(int FN, int SN, out int Total, out int Product)
    {
        Total= FN + SN;
        Product= FN * SN;
    }

}
*/


/*
// Pass by value
class Program

{
    public static void Main()
    {
        int i= 0;
        SimpleMethod(i);
        Console.WriteLine(i);
    }

    public static void SimpleMethod(int j)
    {
        j= 101;
    }
}
*/


/*
// Pass by reference
class Program

{
    public static void Main()
    {
        int i= 0;
        SimpleMethod(ref i);
        Console.WriteLine(i);
    }

    public static void SimpleMethod(ref int j)
    {
        j= 101;
    }
}
*/