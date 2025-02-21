public class Order
{
    public List<Product> products;
    public Customer customer;

    public Order(Customer customer, List<Product> products)
    {
        this.customer = customer;
        this.products = products;
    }

    public string GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in products)
        {
            totalPrice += product.GetTotalPrice();
        }
        if (customer.IsInUSA())
        {
            totalPrice += 5;
        } else
        {
            totalPrice += 35;
        }
        return "Total Price: $" + totalPrice.ToString("F");
    }

    public string GetPackingLabel()
    {
        string order = "Customer: " + customer.GetName() + "\n\n";
        foreach (Product product in products)
        {
            order += product.GetName() + "\n";
        }
        return order;
    }

    public string GetShippingLabel()
    {
        string order = "Customer: " + customer.GetName() + "\n";
        order += "Shipping Address: " + customer.GetAddress() + "\n";
        return order;
    }
}