using System;

class Student
{
    private int _id;
    private string _Name;
    private int _passMark= 35;

    public string Email
    {
        get;
        set;
    }

    public string City
    {
        get;
        set;
    }

    public int PassMark
    {
        get
        {
            return this._passMark;
        }
    }
    
    public string Name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Name can't be null or empty");
            }
            this._Name= value;
        }
        get
        {
            return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
        }       
    }

    public int Id
    {
        set
        {
            if (value <= 0)
            {
                throw new Exception("Student Id can't be negative");
            }
            this._id= value;
        }
        get
        {
            return this._id;
        }
        
    }
}

public class Program
{
    public static void Main()
    {
        Student C1= new Student();
        C1.Id = 2021;
        C1.Name = "Shivang";

        Console.WriteLine("Student id= {0}", C1.Id);
        Console.WriteLine("Student name= {0}", C1.Name);
        Console.WriteLine("Passing mark is= {0}", C1.PassMark);
    }
}
