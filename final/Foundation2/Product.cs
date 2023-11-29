using System.Dynamic;

public class Product {
    private string _name;
    private int _productID;
    private int _quantity;
    private float _price;

    public Product (string name, int ID, int quantity, float price){
        _name = name;
        _productID = ID;
        _quantity = quantity;
        _price = price;
    }

    public float getTotal(){
        return _price * _quantity;
    }

    public string getLabelString(){
        return ($"{_name} - ID:{_productID}");
    }

}