using System.Reflection;

public class Order
{
    Customer _customer;
    List<Product> _productList = new();

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

    public void AddProdcut(string name, string productID, double productPrice, double quantity)
    {
        Product product = new(name, productID, productPrice, quantity);
        _productList.Add(product);
    }

    public void DisplayPackingLabel()
    {

    }

    public void DisplayShippingLabel()
    {
        
    }
}