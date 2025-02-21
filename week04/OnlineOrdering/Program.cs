using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("/n------------------------------------------------------------------/n");
        // instatiate first products list
        List<Product> firstProducts = new List<Product>();
        // add products to firstProducts list
        firstProducts.Add(new Product("Apple", "A1", 1.5, 2));
        firstProducts.Add(new Product("Banana", "B1", 2.5, 3));
        firstProducts.Add(new Product("Cherry", "C1", 3.5, 4));
        // instantiate first customer
        Customer firstCustomer = new Customer("John Doe", new Address("123 Main St", "Springfield", "IL", "USA"));
        // instantiate first order
        Order firstOrder = new Order(firstCustomer, firstProducts);
        // print first order total price
        Console.WriteLine(firstOrder.GetTotalPrice());
        // print first order packing label
        Console.WriteLine(firstOrder.GetPackingLabel());
        // print first order shipping label
        Console.WriteLine(firstOrder.GetShippingLabel());
        Console.WriteLine("/n------------------------------------------------------------------/n");
        // instatiate second products list
        List<Product> secondProducts = new List<Product>();
        // add products to secondProducts list
        secondProducts.Add(new Product("Donut", "D1", 1.5, 2));
        secondProducts.Add(new Product("Eclair", "E1", 2.5, 3));
        secondProducts.Add(new Product("Fudge", "F1", 3.5, 4));
        // instantiate second customer
        Customer secondCustomer = new Customer("Jane Doe", new Address("8283 Dvuketsvuke", "Tafara", "Harare", "Zimbabwe"));
        // instantiate second order 
        Order secondOrder = new Order(secondCustomer, secondProducts);
        // print second order total price
        Console.WriteLine(secondOrder.GetTotalPrice());
        // print second order packing label
        Console.WriteLine(secondOrder.GetPackingLabel());
        // print second order shipping label
        Console.WriteLine(secondOrder.GetShippingLabel());
        Console.WriteLine("/n------------------------------------------------------------------/n");
        // instatiate third products list
        List<Product> thirdProducts = new List<Product>();
        // add products to thirdProducts list
        thirdProducts.Add(new Product("Grape", "G1", 1.5, 2));
        thirdProducts.Add(new Product("Honeydew", "H1", 2.5, 3));
        thirdProducts.Add(new Product("Ice Cream", "I1", 3.5, 4));
        // instantiate third customer
        Customer thirdCustomer = new Customer("Jim Doe", new Address("789 Oak St", "Springfield", "IL", "USA"));
        // instantiate third order
        Order thirdOrder = new Order(thirdCustomer, thirdProducts);
        // print third order total price
        Console.WriteLine(thirdOrder.GetTotalPrice());
        // print third order packing label
        Console.WriteLine(thirdOrder.GetPackingLabel());
        // print third order shipping label
        Console.WriteLine(thirdOrder.GetShippingLabel());
        Console.WriteLine("/n------------------------------------------------------------------/n");        
    }
}