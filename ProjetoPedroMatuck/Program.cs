using System.Numerics;

namespace HelloWorld;

class Program
{
    static void Main(string[] args) {
        Product product1 = new Product("Sea of Thieves", 30, "Jogo eletronico");
        Product product2 = new Product("Lolzinho", 50.5f, "Jogo eletronico");
        Product product3 = new Product("It takes two", 150, "Jogo eletronico");
        
        Order order = new Order();
        order.addProduct(product1);
        order.addProduct(product2);
        order.addProduct(product3);

        Payment payment = new Payment(order);

        PaymentMethod pix = new Pix();
        PaymentMethod credito = new Credito(3);
        payment.setPaymenthMethod(credito);
        payment.generatePayment();

        Console.WriteLine("O pagamento foi aceito? (Simulando retorno de um banco)(escreva true ou false)");
        bool retorno = bool.Parse(Console.ReadLine());

        payment.setPayed(retorno);


        Invoice invoice = payment.generateInvoice();
        invoice.showInvoice();
        

    }
}