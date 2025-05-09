public class Product 
{
    private string name;
    private string id;
    private double price;
    private int quantity;

    public Product(string name, string id, double price, int quantity)
    {
        this.name = name;
        this.id = id;
        this.price = price;
        this.quantity = quantity;
    }

    public string GetName()
    {
        return name + ", " + id;
    }
    public double GetTotalPrice()
    {
        return price * quantity;
    }
}