using System;

class Program
{
    static void Main()
    {
        Person p = new Person();
        p.Name = "Rambo";
        p.Id = 1987;
        p.Income = 2500;

        Console.WriteLine($"Type of p is {p.GetType()}");
        Console.WriteLine($"p.Name = {p.Name}\ttype = {p.Name.GetType()}");
        Console.WriteLine($"p.Id = {p.Id}\ttype = {p.Id.GetType()}");
        Console.WriteLine($"p.Income = {p.Income}\ttype = {p.Income.GetType()}");
    }
}

class Person
{
    public string Name { get; set; } = string.Empty;  // ป้องกัน null
    public int Id { get; set; }                       // เปลี่ยนเป็น int
    public int Income { get; set; }                  
}
