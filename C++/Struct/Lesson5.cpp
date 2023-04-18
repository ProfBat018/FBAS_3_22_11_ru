#include <iostream>

using namespace std;

struct Date {
    uint16_t day{1};
    uint16_t month{1};
    uint16_t year{2023};
};

struct Car {
    char* make{};
    char* model{};
    Date date{};
};

int main()
{
    // Немного про унифицированную инициализацию.


    Car car1 = {
        new char[] {"Mercedes"},
        new char[] {"CLS 63 AMG"},
        { 1, 1, 2023 }
    };


    Car car2;

    car2.make = new char[] {"Mercedes"};
    car2.model = new char[] {"CLS 63 AMG"};
    car2.date.day = 1;
    car2.date.month = 1;
    car2.date.year = 2023;



    return 0;
}