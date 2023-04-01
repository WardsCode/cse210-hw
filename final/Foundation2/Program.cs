using System;

class Program
{
    static void Main(string[] args)
    {
        //instances-Objects:

        Order order1 = new Order();
        Customer newCustomer = new Customer();
        Products newProduct = new Products();
        Address newAddress = new Address();

        //Intro:
        Console.WriteLine("Welcome to the order machine!");

        //Here we ask for the persons info and address: 

        Console.WriteLine("Let´s add your shipping info now!");
        Console.WriteLine();
        Console.WriteLine("What is your name?");                            //Your Name
        string customerName = Console.ReadLine();                           //Customer Class
        newCustomer.SetCustName(customerName);

        Console.WriteLine("What is your street?");                          //Ur Street
        string street = Console.ReadLine();                                 //Address Class
        newAddress.SetStreet(street);
                
        Console.WriteLine("What is your city?");                            //Ur City
        string city = Console.ReadLine();
        newAddress.SetCity(city);

        Console.WriteLine("What is your state/province?");                  //Ur State
        string state = Console.ReadLine();
        newAddress.SetState(state);

        Console.WriteLine("What is your Country?");
        Console.WriteLine("If you are from USA, please tipe -USA- other wise type your country");
        string country = Console.ReadLine();
        newAddress.SetCountry(country);

        Console.WriteLine("Great! Address is added!");
        Console.WriteLine();

        string address = newAddress.GetAddress();                           //Where will be this?
        newCustomer.SetCustAddr(address);

        string question = "";
        while (question.ToLower() != "no")
        {
            Console.WriteLine("Want to order a new product? (Yes/No)");
            question = Console.ReadLine();
            if (question.ToLower() == "yes")
            {
                //Get Product Info: (Product Class)

                Console.WriteLine("Add the Id of the product");                     //Id of Products
                string newOrderId = Console.ReadLine(); 
                int newOrderID = int.Parse(newOrderId);
                newProduct.SetProductId(newOrderID);

                Console.WriteLine("Add the name of the product");                   //Name of Product
                string newOrderName = Console.ReadLine();   
                newProduct.SetProductName(newOrderName);

                Console.WriteLine("Add the price of the product");                  //Price of Product
                string newOrderpriceString = Console.ReadLine(); 
                float newOrderprice = float.Parse(newOrderpriceString);
                newProduct.SetProductPrice(newOrderprice);

                Console.WriteLine("How many will you purchase?");                   // # of Units
                string newOrderQuantityString = Console.ReadLine(); 
                int newOrderQuantity = int.Parse(newOrderQuantityString);
                newProduct.SetProductQuantity(newOrderQuantity);

                //Order info here:
                order1.productList.Add(newProduct);
                Console.WriteLine("Please click enter to get the order summary");
                Console.ReadLine();

                order1.DisplayOrder(newCustomer, newProduct, newAddress );
                
                Console.ReadLine();
            }
            
        }
        Console.WriteLine("YOull order has been completed!");
    }
}