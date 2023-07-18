using System;

// static constructor is used to initialize the static variable.
class Circle
{
    static float _PI;
    int _Radius;

    // static constructor can't have access modifiers.
    // static constructors are called before instance constructors.
    // static constructor is called only once, no matter how many instances we create. 
    static Circle()
    {
        Circle._PI= 3.141F;
    }
    public Circle(int Radius)
    {
        this._Radius= Radius;
    }

    /*
    // If we have a static function like this, we can't call this function using an object of the class.
    // As we have already seen, we need to access a static variable using class name, likewise we will 
    // have to access the static members using class name in the main function.   
    public static void Print()
    {
        
    }
    */

    public float CalculateArea()
    {
        return Circle._PI*this._Radius*this._Radius;
    }
}


/*
// Using static keyword
class Circle
{
    static float _PI= 3.141F;
    int _Radius;

    public Circle(int Radius)
    {
        this._Radius= Radius;
    }

    public float CalculateArea()
    {
        return Circle._PI*this._Radius*this._Radius;
    }
}
*/


/*
// Without using static keyword
class Circle
{
    float _PI= 3.141F;
    int _Radius;

    public Circle(int Radius)
    {
        this._Radius= Radius;
    }

    public float CalculateArea()
    {
        return this._PI*this._Radius*this._Radius;
    }
}
*/

class Program
{
    static void Main()
    {
        Circle C1= new Circle(5);
        float Area1= C1.CalculateArea();
        Console.WriteLine("Area is {0}", Area1);

        Circle C2= new Circle(6);
        float Area2= C2.CalculateArea();
        Console.WriteLine("Area is {0}", Area2);
    }
}

