public class Order
{
    public string _customerName;
    public string _customerAddress;
    public List<Product> _products = new List<Product>();

    public Order(string customerName, string customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    
    public double shippingCost(Product product)
    {
        if (_customerAddress.EndsWith("USA"))
        {
            return 5.00; // Domestic shipping cost
        }
        else
        {
            return 35.00; // International shipping cost
        }
    }
    
    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += (product._price * product._quantity) + shippingCost(product);
        }
        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product._name} (Quantity: {product._quantity})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customerName}\n{_customerAddress}";
    }
}