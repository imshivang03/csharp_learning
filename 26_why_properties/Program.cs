using System;

class Student
{
    private int _id;
    private string _Name;
    private int _passMark= 35;

    public int GetPassMark()
    {
        return this._passMark;
    }

    public void SetName(string Name)
    {
        if (string.IsNullOrEmpty(Name))
        {
            throw new Exception("Name can't be null or empty");
        }
        this._Name= Name;
    }

    public string GetName()
    {
        return string.IsNullOrEmpty(this._Name) ? "No Name" : this._Name;
    }

    public void SetId(int ID)
    {
        if (ID <= 0)
        {
            throw new Exception("Student Id can't be negative");
        }
        this._id= ID;
    }

    public int GetId()
    {
        return this._id;
    }
}

public class Program
{
    public static void Main()
    {
        Student C1= new Student();
        C1.SetId(2021);
        C1.SetName("Shivang");

        Console.WriteLine("Student id= {0}", C1.GetId());
        Console.WriteLine("Student name= {0}", C1.GetName());
        Console.WriteLine("Passing mark is= {0}", C1.GetPassMark());
    }
}
