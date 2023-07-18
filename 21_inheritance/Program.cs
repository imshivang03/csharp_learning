// csharp doesn't support multiple class inheritance which means child class can have only one parent class
// multilevel inheritance is allowed in csharp, child1 class is inheriting from parent class and child2 
// class is inheriting from child1 class so all the properties of child1 and parent class will be 
// available in child2 class.
// parent class constructors are called even before the child class.

using System;

// constructor overloading in csharp
public class ParentClass
{
    public ParentClass()
    {
        Console.WriteLine("ParentClass constructor called");
    }

    // constructor overloading
    public ParentClass(string message)
    {
        Console.WriteLine(message);
    }
}

public class ChildClass: ParentClass
{
    public ChildClass()//: base("Derived class controlling parent class constructor")
    {
        Console.WriteLine("ChildClass constructor called");
    }
}
public class Program
{
    static void Main()
    {
        ChildClass CC= new ChildClass();
    }
}


/*
public class Employee
{
    public string FirstName;
    public string LastName;
    public string email;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
    }
}

public class FullTimeEmmployee : Employee
{
    public float YearlySalary;
}

public class PartTimeEmployee : Employee
{
    public float HourlyRate;
}

class Program
{
    public static void Main()
    {
        FullTimeEmmployee FTE= new FullTimeEmmployee();
        FTE.FirstName= "Shivang";
        FTE.LastName= "Shahi";
        FTE.YearlySalary= 500000;
        FTE.PrintFullName();

        PartTimeEmployee PTE= new PartTimeEmployee();
        PTE.FirstName= "Yash";
        PTE.LastName= "Shahi";
        PTE.HourlyRate= 500000;
        PTE.PrintFullName();
    }
}
*/