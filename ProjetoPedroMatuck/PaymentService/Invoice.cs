class Invoice {
    Payment payment;
    public Invoice(Payment payment) {
        this.payment = payment;
    }
    public void showInvoice() {
        Console.WriteLine("=============RECIBO============");
        payment.getOrder().showItems();
        payment.getPaymentMethod().showPaymentMethod();
        Console.WriteLine("===============================");
    }
}