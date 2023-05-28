class Transport
{
    public string make;
    public string model;
    public int speed;

    public Transport(string make, string model, int speed)
    {
        this.make = make;
        this.model = model;
        this.speed = speed;
    }
}


class Car : Transport
{
    public string color;

    public Car(string make, string model, int speed, string color) : base(make, model, speed)
    {
        this.color = color;
    }
}
