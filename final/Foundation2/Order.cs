public class Order
{
    private Customer _customerName;
    private List<Product> _products; 

    public Order(List<Product> products, Customer customerName)
    {
        _products = products;
        _customerName = customerName;
    }
    
    public void GeneratePackingLabel()
    {
        foreach(Product products in _products)
        {   
            Console.WriteLine(products.CreateProductInfo());
        }
    }

    public void GenerateShippingLabel()
    {
        Console.WriteLine(_customerName.CustomerAddress());
    }

    public string GetTotal()
    {
        int total = 0;

        foreach(Product products in _products)
        {
            total += products.GeneratePrice();
        }

        if (_customerName.GetCountry()== true)
        {
            total += 5;
        }
        else 
        {
            total += 35;
        }
        return $"${total}";
    }

}