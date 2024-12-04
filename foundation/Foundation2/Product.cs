public class Product
{
    private string _name;
    private string _productId;
    private double _pricePerUnit;

    public Product(string name, string productId, double pricePerUnit)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = pricePerUnit;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public double GetPricePerUnit()
    {
        return _pricePerUnit;
    }
}