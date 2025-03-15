class Pix : PaymentMethod {
    public override void generateInvoice(float totalPrice) {
        Console.WriteLine($"Fatura gerada para pagamento com Pix: {totalPrice:C}");
    }
    public override void showPaymentMethod() {
        Console.WriteLine("Pix");
    }
}