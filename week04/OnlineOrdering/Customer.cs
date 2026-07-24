public class Customer
{
    private string _name;
    public Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public string LiveInUSA()
    {
        if (_address.IsInUSA())
        {
            return "Customer lives in the USA.";
        }
        else
        {
            return "Customer does not live in the USA.";
        }
    }
}    