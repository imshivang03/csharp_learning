using System;

class Program
{
    static void Main()
    {
        // implicit conversion
        // float is a bigger datatype than int. So, no loss of data & Exceptions. Hence implicit
        // conversion can happen from float to int
        /*
        int i= 100;
        float f= i;
        Console.WriteLine(f);
        */


        /*
        // explicit conversion
        float f= 100.25F;
        // can't implicitly convert float to int because float has the higher precedence than the int
        // frational part will be lost, float is a bigger data type than int, so there is also a 
        // possibility of overflow exception
        // We can convert float to int in two ways:
        int i = (int)f;

        // Or using Convert class which throws an exception if any error occured
        // int i= Convert.ToInt32(f);
        Console.WriteLine(i);
        */


        /*
        // To convert string (having integer like 300) to an integer we use Parse() method
        string strNumber= "300";
        int i= int.Parse(strNumber);
        Console.WriteLine(i);
        */


        // To convert string (having integer) to an integer we can also use try parse method
        // Parse() method throws an exception if it can't parse the value, whereas TryParse() returns a 
        // bool indicating whether it succeeded or failed
        string strNumber= "3304";
        int Result= 0;
        bool IsConversionSuccessful= int.TryParse(strNumber, out Result);

        if (IsConversionSuccessful)
        {
            Console.WriteLine(Result);
        }
        else
        {
            Console.WriteLine("Please enter a valid number");
        }
    }
}