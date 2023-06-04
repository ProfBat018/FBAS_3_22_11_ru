public class Car extends Transport {
    public String color;
    public Car(String make, String model, int speed, String color) {
        super(make, model, speed);
        this.color = color;
    }
}
