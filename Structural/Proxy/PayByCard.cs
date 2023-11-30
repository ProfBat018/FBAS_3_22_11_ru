namespace Proxy;

public class PayByCard : IPayment
{

    public void Withdraw(int Amount)
    {
        Console.WriteLine("Withdraw by card");
    }

    public void Pay(int Amount)
    {
        Withdraw(Amount);
        Console.WriteLine("Pay by card");
        PayBycash payBycash = new PayBycash();  
        payBycash.Pay(Amount);
    }
}