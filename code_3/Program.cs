using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string [] args)
        {
            bool canIVote= true;

            Console.WriteLine("Biggest Integer: {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer: {0}", int.MinValue);

            Console.WriteLine("Biggest Long: {0}", long.MaxValue);
            Console.WriteLine("Smallest Long: {0}", long.MinValue);

            decimal decPiVal= 3.1415926535897932384626433832M;
            decimal decBigNum= 3.00000000000000000000000000011M;
            Console.WriteLine("Dec : PI + bigNum= {0}", decPiVal+decBigNum);

            Console.WriteLine("Biggest Decimal: {0}", Decimal.MaxValue);

            Console.WriteLine("Biggest Double : {0}", Double.MaxValue);
            double dblPiVal= 3.14159265358979;
            double dblBigNum= 3.00000000000002;
            Console.WriteLine("DBL: PI + bigNum= {0}", dblPiVal + dblBigNum);

            Console.WriteLine("Biggest Float: {0}", float.MaxValue);
            double fltPiVal= 3.141592F;
            double fltBigNum= 3.000002F;
            Console.WriteLine("FLT : PI + bigNum= {0}", fltPiVal + fltBigNum);
        }
    }
}