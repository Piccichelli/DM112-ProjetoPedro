class Credito : PaymentMethod {
    private int numberOfInstallments;
    private float interestRate;

    public Credito(int numberOfInstallments) {
        this.numberOfInstallments = numberOfInstallments;
        calculateInterestRate(numberOfInstallments);
    }
    public override void generateInvoice(float totalPrice) {
        float totalAmountWithInterest  = totalPrice * (1 + this.interestRate/100);
        float installmentAmount = totalAmountWithInterest/this.numberOfInstallments;


        Console.WriteLine($"Fatura gerada para pagamento com Crédito: {totalPrice:C}");
        Console.WriteLine($"Número de parcelas: {numberOfInstallments}");
        Console.WriteLine($"Taxa de juros: {interestRate}%");
        Console.WriteLine($"Valor total com juros: {totalAmountWithInterest:C}");
        Console.WriteLine($"Valor de cada parcela: {installmentAmount:C}");
    }
    private void calculateInterestRate(int numberOfInstallments) {

        if(numberOfInstallments > 12) {
            throw new ArgumentException("Número de parcelas não pode ser superior a 12.");
        }
        else if(numberOfInstallments <= 0) {
            throw new ArgumentException("Número de parcelas não pode ser menor que 1.");
        }

        if(numberOfInstallments < 3) {
            this.interestRate = 0;
        } else if(numberOfInstallments >= 3 && numberOfInstallments <= 6) {
            this.interestRate = 5;
        } else {
            this.interestRate = 10;
        }
    }

    public override void showPaymentMethod(){
        Console.WriteLine("Crédito");
    }
}