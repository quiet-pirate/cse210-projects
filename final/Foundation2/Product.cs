using System;
class Product
{
    private int _quantity = 0;
    private double _price = 0.0;
    private int _productId = 0;
    private string _name = "";

    public Product(string name, string productId)
    {

    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public int GetId()
    {
        return _productId;
    }
    public double CalculatePrice()
    {
        return _quantity*_price;
    }

    public void DisplayProduct()
    {
        Console.WriteLine($"{_productId}-{_name}");
    }
}