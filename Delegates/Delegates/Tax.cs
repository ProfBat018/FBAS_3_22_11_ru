namespace Delegates;

public class Tax
{
    public string Name { get; set; } // имя налога
    public decimal Rate { get; set; } // ставка налога
    public Func<decimal, decimal> TaxDelegate { get; set; } // делегат налога
}