public class Order {
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order (List<Product> products, Customer customer){
        _products = products;
        _customer = customer;
    }

    public float getTotalPrice(){
        float shipping = 0;
        float total = 0;
        if (_customer.isFromUS()){
            shipping = 5;
        } else {
            shipping = 35;
        }

        foreach(Product product in _products){
            total += product.getTotal();
        }

        total += shipping;

        return total;
    }

    public string getPackingLabel(){
        string label = "";

        foreach(Product product in _products){
            label += ($"{product.getLabelString()}\n");
        }

        return label;
    }

    public string getShippingLabel(){
        return ($"{_customer.getName()}\n{_customer.getAddressStringFromAddress()}");
    }

}