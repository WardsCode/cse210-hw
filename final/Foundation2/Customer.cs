using System;

public class Customer
{
    private string _customerName;

    private string _address;

    public Customer ()
    {

    }

    public string GetCustName()
    {
        return _customerName;
    }

    public void SetCustName(string customer)
    {
        _customerName = customer;
    }

        public void SetCustAddr(string add)
    {
        _address = add;
    }

}