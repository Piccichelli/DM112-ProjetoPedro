class Product {
    private string name;
    public string Name {
        get {return name;}
        set {name = value;}
    }
    private float price;
    public float Price {
        get {return price;}
        set {price = value;}
    }
    private string category;
    public string Category {
        get {return category;}
        set {category = value;}
    } 

    public Product(string name, float price, string category) {
        Name = name;
        Price = price;
        Category = category;
    }
}