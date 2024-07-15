using System.Reflection;

public class Order
{
    Customer _customer;
    List<Product> _productList = new();
    double _subTotal = 0;
    double _total = 0;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public Order(string name, string address, string city, string state, string country)
    {
        _customer = new(name, address, city, state, country);
    }

    public void AddProduct(Product product)
    {
        _productList.Add(product);
    }

    public void AddProduct(string name, string productID, double productPrice, double quantity)
    {
        Product product = new(name, productID, productPrice, quantity);
        _productList.Add(product);
    }

    public void DisplayPackingLabel()
{
    Console.WriteLine("Packing Label:");

    foreach (Product product in _productList)
    {
        int nameWidth = 25;

        Console.WriteLine($"{product.GetProductName().PadRight(nameWidth)} {product.GetProductID()}");

        _subTotal =  _subTotal + product.GetTotalCost();
    }
}

    public void DisplayShippingLabel()
    {
        Console.WriteLine("Shipping Label:");
        // Console.WriteLine($"{_customer.GetName()} {_customer.GetAddressInfo()}");

        int labelWidth = 25; 

        Console.WriteLine($"{ "Name:".PadRight(labelWidth) }{ _customer.GetName() }");
        Console.WriteLine($"{ "Address:".PadRight(labelWidth) }{ _customer.GetAddressInfo() }");

        if (_customer.InUSA() == true)
        {
            _total = _subTotal + 5;
        }
        else
        {
            _total = _subTotal + 35;
        }
    }

    public void DisplayReciept()
    {
        int labelWidth = 25; 


        Console.WriteLine($"{ "Subtotal:".PadRight(labelWidth) }{_subTotal}");
        Console.WriteLine($"{ "Total:".PadRight(labelWidth) }{_total}");
    }
}