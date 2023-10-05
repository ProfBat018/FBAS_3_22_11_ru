class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public float Fuel { get; set; } = 1;

    public event Action FuelConsumptionEvent;
}







