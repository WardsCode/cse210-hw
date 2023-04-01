using System;

public class Order
{
    public List<Products> productList = new List<Products>();

    public Order()
    {

    }

    public void DisplayOrder(Customer newCustomer, Products newProduct, Address newAddress )
    {
        Console.WriteLine("");
        Console.WriteLine("Shipping Lable:");
        Console.WriteLine($"Client: {newCustomer.GetCustName()}");
        Console.WriteLine($"Address: {newAddress.GetAddress()}");
        Console.WriteLine("");
        Console.WriteLine("Order Info:");

        string condt = newAddress.IfUsa();
        foreach (Products product in productList)
        {
            Console.WriteLine(product.DisplayProductSummary(condt));
        }
    }    
}