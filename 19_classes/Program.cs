﻿using System;

class Customer
{
    string _firstName;
    string _lastName;

    public Customer()
        : this("No FirstName Provided", "No LastName Provided")
    {

    }

    public Customer(string FirstName, string LastName)
    {
        this._firstName= FirstName;
        this._lastName= LastName;
    }

    public void PrintFullName()
    {
        Console.WriteLine("Full name= {0}",this._firstName + " "+ this._lastName);
    }

    ~Customer()
    {
        // clean up code (destructor)
    }
}

class Program
{
    public static void Main()
    {
        Customer C1= new Customer();
        C1.PrintFullName();
        Customer C2= new Customer("Shivang", "Shahi");
        C2.PrintFullName();
    }
}