namespace Proxy;

public class PayBycash : IPayment
{
    public void Pay(int Amount)
    {
        Console.WriteLine("Pay by cash");
    }
}