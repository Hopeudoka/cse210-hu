public class Product
{
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    // Add constructor
    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Add methods
    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }

    public decimal GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }

    public override string ToString()
    {
        return $"{_name} (ID: {_productId}) - Quantity: {_quantity}, Unit Price: {_price:C}, Total: {GetTotalCost():C}";
    }
}