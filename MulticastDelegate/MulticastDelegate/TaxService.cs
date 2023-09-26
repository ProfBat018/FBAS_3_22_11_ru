namespace MulticastDelegate;

public class TaxService
{
    public TaxDelegate? TaxAction { get; set; }

    public void AddTax(TaxDelegate taxAction)
    {
        TaxAction += taxAction; // multicast delegate addition
    }
    
    public void CalculateTax(decimal amount)
    {
        decimal totalTax = 0;
        TaxAction?.Invoke(amount, ref totalTax);
    }
}