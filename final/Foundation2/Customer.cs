using System;
public class Customer
{
    private string _customerName = "";

    public class Address
    {
        private string _street = "";
        private string _city = "";
        private string _stateProvince = "";
        private string _country = "";
        private bool _us = true;

        public void DisplayAddress()
        {
            Console.WriteLine($"{_street}\n"+
            ($"{_city}, {_stateProvince}. {_country}"));
        }

        public void UsAdress()
        {
            Convert.ToBoolean(_country);
            if(_us == true)
            {
                Console.WriteLine("US Address, Shipping $5");
            }
            else
            {
                Console.WriteLine("Not US Adress, Shipping $35");
            }

        }
    }
    //address is a class
    //call method from the address class
}