class Program
{
    static void Main()
    {
        Person p = new Person();
        p.name = "Rambo";           // กำหนดค่าให้ name
        p.id = "1987";              // กำหนดค่าให้ id
        p.income = 2500;            // กำหนดค่าให้ income

        // แสดงผลลัพธ์ข้อมูล
        System.Console.WriteLine($"Type of p is {p.GetType()}");
        System.Console.WriteLine($"p.name = {p.name}\ttype = {p.name.GetType()}");
        System.Console.WriteLine($"p.id = {p.id}\ttype = {p.id.GetType()}");
        System.Console.WriteLine($"p.income = {p.income}\ttype = {p.income.GetType()}");
    }
}

class Person
{
    public string name;  // ฟิลด์ name เป็น non-nullable string
    public string id;    // ฟิลด์ id เป็น non-nullable string
    public int income;   // ฟิลด์ income เป็น non-nullable int
}
