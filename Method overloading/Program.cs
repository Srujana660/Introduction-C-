using System;
public class Student
{
    private int _id;
    private string _name;
    private int _marks = 85;

    public void Setid(int id)
    {
        if (id <= 0)
        {
            throw new ArgumentException("not valid");
        }
        this._id = id;
    }
    public int Getid()
    {
        return this._id;
    }
    public void Setname(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("invalid");
        }
        this._name = name;
    }

  
    public string Getname()
    {
        return string.IsNullOrEmpty(this._name) ? "invalid" : this._name;
    }

    public int Getmarks()
    {
        return this._marks;
    }
    public class Program
    {
        public static void Main()
        {
            Student s = new Student();
            s.Setid(1);
            s.Setname("srujana");
            Console.WriteLine("name = {0}", s.Getname());
            Console.WriteLine("marks = {0}", s.Getmarks());
            Console.WriteLine("id = {0}", s.Getid());
        }
        
    }
}