using System;
public class Order
{
    public List<string> customer;
    public List<string> products;
    public int _shipping = 0;

    public double TotalCost(int quantity, double price, bool us)
    {
        return (quantity*price)+_shipping;
        // if(us==true)
        // {
        //     return (quantity*price)+5;
        // }
    }
    public void PackingLabel(string name, int productId)
    {
        Console.WriteLine($"{name}- ({productId})");
    }
    public void ShippingLabel(string city)
    {
        Console.WriteLine($"{city}");
    }

}
