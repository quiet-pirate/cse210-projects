using System;
public class Order
{
    public List<string> customer;
    public List<string> products;
    public int _shipping = 0;

    public double TotalCost()
    {
        return +_shipping;
    }

}