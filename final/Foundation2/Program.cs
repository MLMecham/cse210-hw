using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("\n\n");
        // Console.WriteLine("Hello Foundation2 World!");
        Address testAddress1 = new("470 N 560 W", "WarSaw", "Mazowieckie", "Poland");
        Address testAddress2 = new("Gordon Steet Crossing 1098", "Seatle", "Washington", "united states of america");

        Customer customer1 = new("Mike", testAddress1);
        Customer customer2 = new("Megan", "North Bridge bulding 3 room 117", "Denver", "CO", "USA");

        Product product1 = new("LED lightbulb", "LTB50B", 19.99, 3);
        Product product2 = new("Sentient Plant Matter", "REDACTED", 49.99, 1);
        Product product3 = new("Foundtain of Youth", "NODIE", 2.99, 1);
        Product product4 = new("Holy Water Rope", "RP310", 49.99, 5);
        Product product5 = new("Modafinil", "DRUG231", 29.98, 1);
        Product product6 = new("The Key of Soloman", "SOID:JFS", 0.00, 0);

        Order order1 = new(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 =new(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);



        // inUSA = customer2.InUSA();
        // Console.WriteLine(customer2.GetName());
        // Console.WriteLine(customer2.GetAddressInfo());
        
        // if (inUSA == true)
        // {
        //     Console.WriteLine("country is in the usa");
        // }

        order1.DisplayPackingLabel();
        Console.WriteLine("");
        order1.DisplayShippingLabel();
        Console.WriteLine("");
        order1.DisplayReciept();

        Console.WriteLine("\n\n");

        order2.DisplayPackingLabel();
        Console.WriteLine("");
        order2.DisplayShippingLabel();
        Console.WriteLine("");
        order2.DisplayReciept();



    }
}