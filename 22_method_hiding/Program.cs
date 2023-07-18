using System;

// An Employee object can't fulfil all the responsibilities of a PartTimeEmployee whereas a 
// PartTimeEmployee object can fulfill all the responsibilities of an Employee
// A parent class reference variable can point to a child class object whereas a child class reference 
// variable can't point to a parent class object
class Employee
{
    public string FirstName;
    public string LastName;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName +" "+ LastName);
    }
}

class PartTimeEmployee : Employee
{
    public new void PrintFullName()
    {
        Console.WriteLine(FirstName +" "+ LastName + " - contractor");
    }
}

class FullTimeEmployee: Employee
{

}

class Program
{
    public static void Main()
    {
        // A child class can fulfil all the responsibilities of parent class
        // Assigning the object of child type to a reference variable of type parent
        // Now PTE is actually an object of parent class Employee
        Employee PTE= new PartTimeEmployee();
        PTE.FirstName= "PartTime";
        PTE.LastName= "Employee";
        PTE.PrintFullName();

        FullTimeEmployee FTE= new FullTimeEmployee();
        FTE.FirstName= "FullTime";
        FTE.LastName= "Employee";
        FTE.PrintFullName();
    }
}


/*
// using typecast operator to convert the child class object to be of type parent, so that we can access
// the parent class function which is actually hidden.
class Employee
{
    public string FirstName;
    public string LastName;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName +" "+ LastName);
    }
}

class PartTimeEmployee : Employee
{
    public new void PrintFullName()
    {
        // we are calling the base class print function which is hidden.
        base.PrintFullName();
        //Console.WriteLine(FirstName +" "+ LastName + " - contractor");
    }
}

class FullTimeEmployee: Employee
{

}

class Program
{
    public static void Main()
    {
        PartTimeEmployee PTE= new PartTimeEmployee();
        PTE.FirstName= "PartTime";
        PTE.LastName= "Employee";
        // PTE.PrintFullName();
        // typecasting the child class object to a parent class object 
        ((Employee)PTE).PrintFullName();

        FullTimeEmployee FTE= new FullTimeEmployee();
        FTE.FirstName= "FullTime";
        FTE.LastName= "Employee";
        FTE.PrintFullName();
    }
}
*/


// Accessing the base class PrintFullName method by calling PrintFullName method of base class in the
// child class using base keyword.
/*
class Employee
{
    public string FirstName;
    public string LastName;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName +" "+ LastName);
    }
}

class PartTimeEmployee : Employee
{
    public new void PrintFullName()
    {
        // we are calling the base class print function which is hidden.
        base.PrintFullName();
        //Console.WriteLine(FirstName +" "+ LastName + " - contractor");
    }
}

class FullTimeEmployee: Employee
{

}

class Program
{
    public static void Main()
    {
        PartTimeEmployee PTE= new PartTimeEmployee();
        PTE.FirstName= "PartTime";
        PTE.LastName= "Employee";
        PTE.PrintFullName();

        FullTimeEmployee FTE= new FullTimeEmployee();
        FTE.FirstName= "FullTime";
        FTE.LastName= "Employee";
        FTE.PrintFullName();
    }
}
*/


/*
// Method Hiding in csharp, base class method is hidden when we have same method name in the child 
// class i.e PrintFullName, the PrintFullName method of child class will get executed. 
class Employee
{
    public string FirstName;
    public string LastName;

    public void PrintFullName()
    {
        Console.WriteLine(FirstName +" "+ LastName);
    }
}

class PartTimeEmployee : Employee
{
    // this fn will hide the PrintFullName method in the parent class and we are using "new" keyword here
    // to do that.
    public new void PrintFullName()
    {
        Console.WriteLine(FirstName +" "+ LastName + " - contractor");
    }
}

class FullTimeEmployee: Employee
{

}

class Program
{
    public static void Main()
    {
        PartTimeEmployee PTE= new PartTimeEmployee();
        PTE.FirstName= "PartTime";
        PTE.LastName= "Employee";
        PTE.PrintFullName();
        

        FullTimeEmployee FTE= new FullTimeEmployee();
        FTE.FirstName= "FullTime";
        FTE.LastName= "Employee";
        FTE.PrintFullName();
    }
}
*/
