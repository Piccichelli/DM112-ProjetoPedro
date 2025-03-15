using System.Collections;
using System.Linq;
class Order {
    private List<Product> products;
    public Order() {
        products = new List<Product>();
    }

    public void addProduct(Product product) {
        this.products.Add(product);
    }

    public bool deleteProduct(Product product) {
        return this.products.Remove(product);
    }
    public float calculateOrderPrice() {
         return this.products.Aggregate(0.0f, (acc, product) => acc + product.Price); 
    }
    public void showItems() {
        Console.WriteLine("=============ITENS=============");
        int cont = 1;
        products.ForEach(product => {
            Console.WriteLine($"Produto {cont}");
            Console.WriteLine($"Nome: {product.Name}");
            Console.WriteLine($"Preco: {product.Price:C}");
            Console.WriteLine($"Categoria: {product.Category}");
            Console.WriteLine("------------------------------");
            cont++;
        });
        Console.WriteLine("===============================");
    }
}