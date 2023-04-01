using System;

public class Products
{

    private string _productName;
    private int _productId;
    private int _productQuantity;
    private float _productPrice;

    public Products()                           //Constructor
    {
        
    }

    //Setters
    public void SetProductName (string name)
    {
        _productName = name;   
    }
        public void SetProductQuantity (int quantity)
    {
        _productQuantity = quantity;   
    }
        public void SetProductPrice (float price)
    {
        _productPrice = price;   
    }    

        public void SetProductId (int id)
    {
        _productId = id;   
    }    

    //Getters
    public string GetProductName()
    {
        return _productName;
    }
    public int GetQuantity()
    {
        return _productQuantity;
    }

    public float CalculatePriceAmountUSA()
    {
        return ((_productPrice * _productQuantity) + 5);
    }
    public float CalculatePriceAmountNoUSA()
    {
        return ((_productPrice * _productQuantity) + 35);
    }
    
    public string DisplayProductSummary(string ifUsa)
    {

        Console.WriteLine($"{_productId} {_productName} - Price: {_productPrice} Quantity: {_productQuantity}");
        if (ifUsa == "usa")
        {
            return $"Total amount: {CalculatePriceAmountUSA()} (Total amount + Shipping Fee)";
        }
        else 
        {
            return $"Total amount: {CalculatePriceAmountNoUSA()} (Total amount + Shipping Fee) ";
        }

    }

}