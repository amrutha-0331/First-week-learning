using New_Learning;
using System;
class Program
{
    /*static void Main(string[] args)
    {
        Console.WriteLine(Employee());

    }*/
    static void Main(string[] args)
    {
     /*   Storage<int> storage = new Storage<int>();
        storage.Item = 100;
        storage.PrintItem();

        Storage<string> storage1 = new Storage<string>();
        storage1.Item = "Hello";
        storage1.PrintItem();*/
        
        Storage<int> numbers = new Storage<int>();
        numbers.AddItem(1);
        numbers.AddItem(2);
        numbers.AddItem(3);

        numbers.PrintALl();

        numbers.RemoveItem(1);

        numbers.PrintALl();
    }
    public int Employee()
    {
        {
            int empId = 24;

            return empId;
        }
    }
}