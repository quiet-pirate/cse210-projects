using System;
public class Address
{
    private string _street = "";
    private string _city = "";
    private string _state = "";
    private string _country = "";
    private bool _US = true;

    public void DisplayAddress()
    {
        Console.WriteLine($"{_street}  {_city}, {_state}. {_country}");
    }

    public void UsAdress()
    {
        Convert.ToBoolean(_country);
        if(_US == true)
        {
            Console.WriteLine("US Address, Shipping $5");
        }
        else
        {
            Console.WriteLine("Not US Adress, Shipping $35");
        }

    }
}