public class Product
{
    string _name;
    string _productID;
    double _productPrice;
    double _quantity;

    public Product(string name, string productID, double productPrice, double quantity)
    {
        _name = name;
        _productID = productID;
        _productPrice = productPrice;
        _quantity = quantity;

    }

    public string GetProductName()
    {
        return _name;
    }

    public string GetProductID()
    {
        return _productID;
    }

    public double GetTotalCost()
    {
        return _productPrice * _quantity;
    }
}