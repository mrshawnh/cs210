public class Order{

    List<Product> _productList = new List<Product>();
    private double _shippingPrice;

    public void CalculateFinalPrice(Address address){
        foreach (Product product in _productList){
            double price = product.GetFinalPrice();
            _shippingPrice += price;
        }

        if (address.GetInUS() == "true"){
            _shippingPrice = _shippingPrice + 5;
        }
        else{
            _shippingPrice = _shippingPrice + 35;
        }
        double shippingPrice = Math.Round(_shippingPrice, 2);

        Console.WriteLine($"The total price of the order including the shipping cost is ${shippingPrice}.");
    }

    public void PackingLabel(){
        Console.WriteLine("Packing Label:");
        foreach (Product product in _productList){
            string productName = product.GetProductName();
            string productID = product.GetProductID();
            Console.WriteLine($"{productName} - {productID}");
        }
    }

    public void ShippingLabel(Customer customer, Address address){
        string customerName = customer.GetName();
        string customerAddress = address.FullAddress();

        Console.WriteLine(customerName);
        Console.WriteLine(customerAddress);
    }

    public void AddProduct(Product product){
        _productList.Add(product);
    }




}