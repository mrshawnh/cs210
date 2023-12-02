public class Product{

    private string _productName;
    private string _productID;
    private double _quantity;
    private double _price;
    private double _finalPrice;

    public Product(string productName, string productID, double quantity, double price){
        _productName = productName;
        _productID = productID;
        _quantity = quantity;
        _price = price;
    }

    public void CalculatePrice(){
        _finalPrice = _quantity * _price;
    }

    public double GetFinalPrice(){
        CalculatePrice();
        return _finalPrice;
    }

    public string GetProductName(){
        return _productName;
    }

    public string GetProductID(){
        return _productID;
    }
}