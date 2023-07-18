using System;

// Method Hiding
public class BaseClass
{
    public virtual void Print()
    {
        Console.WriteLine("I am a base class print method");
    }
}

public class DerivedClass : BaseClass
{
    public new void Print()
    {
        Console.WriteLine("I am a derived class print method");
    }
}

class Program
{
    public static void Main()
    {
        BaseClass B= new DerivedClass();
        B.Print();
    }
}


/*
// Method Overriding
public class BaseClass
{
    public virtual void Print()
    {
        Console.WriteLine("I am a base class print method");
    }
}

public class DerivedClass : BaseClass
{
    public override void Print()
    {
        Console.WriteLine("I am a derived class print method");
    }
}

class Program
{
    public static void Main()
    {
        BaseClass B= new DerivedClass();
        B.Print();
    }
}
*/