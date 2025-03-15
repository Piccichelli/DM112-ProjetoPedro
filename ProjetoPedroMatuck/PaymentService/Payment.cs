class Payment {
    private PaymentMethod? paymentMethod;
    Order order;
    private bool payed;

    public Payment(Order order) {
        this.order = order;
        this.payed = false;
    }

    //Adicionamos esse método calculatePaymentPrice pois pode ser necessário calcular outros fatores
    //em cima do valor do pedido, como por exemplo, o valor da entrega um desconto
    public float calculatePaymentPrice() {
        return this.order.calculateOrderPrice();
    }
    public void setPaymenthMethod(PaymentMethod paymentMethod) {
        this.paymentMethod = paymentMethod;
    }

    public void generatePayment() {
        if(this.paymentMethod != null) {
            paymentMethod.generateInvoice(this.calculatePaymentPrice());
        } else {
            Console.WriteLine("Você deve selecionar uma forma de pagamento");
        }
    }
    public Order getOrder() {
        return this.order;
    }
    public PaymentMethod getPaymentMethod() {
        return this.paymentMethod;
    }
    public void setPayed(bool payed) {
        this.payed = payed;
    }

    public Invoice generateInvoice() {
        if(this.payed) return new Invoice(this);
        
        throw new ArgumentException("Pedido ainda não foi pago.");
    }
}