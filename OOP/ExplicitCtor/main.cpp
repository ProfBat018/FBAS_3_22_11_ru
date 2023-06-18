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

    Car(uint16_t year) {
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
    print<Car>(Car()); // явно

    print<Car>({2015});




    return 0;
}
