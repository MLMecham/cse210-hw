using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation2 World!");
        Address testAddress1 = new("470 N 560 W", "Baltimore", "Poland", "Poland 2");
        Address testAddress2 = new("565465464", "Seatle", "Washington", "united states of america");
        bool inUSA;

        Customer customer1 = new("Mike", testAddress1);
        Customer customer2 = new("Megan", "North Bridge bulding 3 room 117", "Denver", "CO", "USA");



        inUSA = customer2.InUSA();
        Console.WriteLine(customer2.GetName());
        Console.WriteLine(customer2.GetAddressInfo());
        




        if (inUSA == true)
        {
            Console.WriteLine("country is in the usa");
        }

    }
}