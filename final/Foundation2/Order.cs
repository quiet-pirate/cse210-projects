using System;
public class Order
{
    public List<string> customer;
    public List<string> products;
    public int _shipping = 0;

    public double TotalCost(int quantity, double price)
    {
        //return Product.CalculatePrice()+_shipping;
    }
    public string PackingLabel()
    {
        Console.WriteLine("Packing Label");
    }
    public string ShippingLabel()
    {
        Console.WriteLine("")
    }

}
