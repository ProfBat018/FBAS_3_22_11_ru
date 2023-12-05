class PaymentDecoratorWithTwoCards : PaymentDecorator
{
    private List<IPayment> _paymentTypes;
    public PaymentDecoratorWithTwoCards(IPayment payment) : base(payment)
    {

    }

    public PaymentDecoratorWithTwoCards(IEnumerable<IPayment> payments)
    {
        _paymentTypes = new List<IPayment>(payments);
    }

    public void AddPaymentType(IPayment payment)
    {
        _paymentTypes.Add(payment);
    }

    public override void Pay(int amout)
    {
        foreach (var payment in _paymentTypes)
        {
            payment.Pay(amout);
        }
    }
}