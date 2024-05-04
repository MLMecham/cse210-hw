using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Sandbox World!");

        List<object> myList = new();
        myList.Add("Super cool string");
        myList.Add(55);

        foreach (object item in myList)
        {
            Console.WriteLine(item);
        }


    }
}