#nullable enable
using System;

class MyClass
{
    public int F1;          // ค่าเริ่มต้นเป็น 0 (Implicit initialization)
    public string F2 { get; set; } = ""; // ใช้ Property และกำหนดค่าเริ่มต้น
    public int F3 { get; set; } = 100;   // ใช้ Property เพื่อความยืดหยุ่น
    public string F4 { get; set; } = "ASDF"; // ใช้ Property เพื่อความปลอดภัย
}

class Program
{
    static void Main()
    {
        var myObj = new MyClass();
        
        Console.WriteLine($"Default integer      F1 = {myObj.F1}");
        Console.WriteLine($"Default string       F2 = {myObj.F2}");
        Console.WriteLine($"Initialized integer  F3 = {myObj.F3}");
        Console.WriteLine($"Initialized string   F4 = {myObj.F4}");
    }
}
