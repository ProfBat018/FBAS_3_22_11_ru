#include <iostream>
#include <string>
#include <cstdint>

using namespace std;

class Car
{
public:

    explicit Car() {
        cout << "default constructor" << endl;
        this->make = "Mercedes";
        this->model = "C63 AMG";
        this->year = 2014;

    }

    explicit Car(uint16_t year) {
        this->make = "Mercedes";
        this->model = "C63 AMG";
        this->year = year;
    }

    explicit Car(string make, string model, uint16_t year)
    {
        this->make = make;
        this->model = model;
        this->year = year;
    }

    friend ostream& operator<<(ostream& os, const Car& car)
    {
        os << car.make << " " << car.model << " " << car.year;
        return os;
    }

private:
    string make;
    string model;
    uint16_t year;
};


template <typename T>
void print(T value)
{
    cout << value << endl;
}


int main()
{
    // print<Car>({}); //  Это что за бред ?! неявно
     
    // Это тоже самое, что и предыдущая строка.
    // Но тут уже понятно, что мы создаем объект класса Car
    // print<Car>(Car(2015)); // явно

    // print<Car>(2015);

    Car a(2015);
    Car b("BMW", "M5", 2015);
    Car b2 {"BMW", "M5", 2015};

    b = a;
    cout << b << endl;  

    Car c(b);
    cout << c << endl;



    return 0;
}
