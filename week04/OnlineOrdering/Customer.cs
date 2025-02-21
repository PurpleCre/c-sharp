public class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address) {
        this.name = name;
        this.address = address;
    }

    public string GetName() {
        return name;
    }

    public string GetAddress() {
        return address.GetAddress();
    }

    public bool IsInUSA() {
        return address.IsInUSA();
    }
}