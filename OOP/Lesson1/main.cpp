#include <iostream>

using namespace std;


#pragma region Part1

/*

struct Car {
    char* make{};
    char* model{};
    int year{};

    // Конструктор по умолчанию. Он тут и так уже был, но мы его не видели.
    // Мы его создали для того чтобы его изменить

//    Car() {
//        make = new char[30]{};
//        model = new char[30]{};
//
//        cout << "Car() called" << endl;
//    }

    // Конструктор с параметрами
    Car(char* make, char* model, int year) {
        this->make = make;
        this->model = model;
        this->year = year;

        cout << "Car(char*, char*, int) called" << endl;
    }

    // Упрощенный синтаксис конструктора по умолчанию
    Car() = default;
};


int main() {

    Car b; // Неявно вызывается коструктор по умолчанию

    Car c{}; //Обычный объект стурктуры Car в Stack. Контруктор по умолчанию вызывется из-за инициализации фигурными скобками

    Car d = Car(); // явно вызывается конструктор по умолчанию. Переменная, все еще в Stack

    Car* e = new Car(); // Вызывается конструктор по умолчанию. Переменная в Stack, но объект в Heap



    return 0;
}

 */

#pragma endregion

#pragma region Part2

/*
struct Car {
    char* make{};
    char* model{};
    int year{};

    Car(char* make, char* model, int year) {
        this->make = make;
        this->model = model;
        this->year = year;
    }

    void print() {
        cout << "Make: " << make << endl;
        cout << "Model: " << model << endl;
        cout << "Year: " << year << endl;
    }
};

Car* createCar() {
    char* make = new char[30]{};
    char* model = new char[30]{};
    int year{};

    cout << "Enter make: ";
    cin >> make;

    cout << "Enter model: ";
    cin >> model;

    cout << "Enter year: ";
    cin >> year;

    return new Car(make, model, year);
}


int main() {

    Car* car = createCar();
    car->print();

    return 0;
}
*/
#pragma endregion


#pragma region Part3

struct Car {

    char *make{};
    char *model{};
    int year{};

    Car() {
        this->make = new char[30]{};
        this->model = new char[30]{};

        cin.ignore();

        cout << "Enter make: ";
        cin.getline(this->make, 30);

        cout << "Enter model: ";
        cin.getline(this->model, 30);

        cout << "Enter year: ";
        cin >> this->year;
    }

    void print() {
        cout << this << endl;
        cout << "Make: " << (*this).make << endl;
        cout << "Model: " << this->model << endl;
        cout << "Year: " << this->year << endl;
    }
};


int main() {

    Car *cars = new Car[2]{}; // Выделяем память под 2 объекта типа Car

    cars[0].print(); // Mercedes

    cars[1].print(); // BMW




    return 0;
}

#pragma endregion