// Надо создать менеджер автосалона в котором будут машины

#include <iostream>

using namespace std;

#pragma region WithoutStructs
/*
void createShowroom(char*& showroomName, uint16_t& carCapacity) {

    showroomName = new char[20]{}; // Выделяем память под указатель showroomName

    cout << "Enter showroom name: ";
    cin.getline(showroomName, 20); // Mercedes

    cout << "Enter car capacity: ";
    cin >> carCapacity; // 10
}

void createCar(char** carMakes, char** carModels, float* prices) {

}

int main() {

    char* showroomName{}; // char указатель
    uint16_t carCapacity{}; // Максимальное количество машин в автосалоне
    uint16_t carCount{}; // Количество машин в автосалоне

    createShowroom(showroomName, carCapacity); // при передаче указателя в функцию, мы передаем его копию, поэтому в функции мы можем изменить значение указателя, но не его адрес

    cout << showroomName << endl;
    cout << carCapacity << endl;

    char** carMakes = new char* [carCapacity]{};  // Mercedes, BMW
    char** carModels = new char* [carCapacity]{}; // CLS63, X5
    float* prices = new float[carCapacity]{}; // 150000, 100000


    return 0;
}
*/
#pragma endregion

#pragma region WithStructs

struct Car {
    char *make{}; // Марка машины
    char *model{}; // Модель машины
    float price{}; // Цена машины

    void showCar() {
        cout << "Make: " << make << endl;
        cout << "Model: " << model << endl;
        cout << "Price: " << price << endl;
    }
};

struct Showroom {
    char *name{}; // Название автосалона
    uint16_t carCapacity{10}; // Максимальное количество машин в автосалоне
    uint16_t carCount{}; // Количество машин в автосалоне в данный момент
    Car *cars = new Car[carCapacity]{}; // Массив машин. Такое использование называется агрегацией или композицией


    Car createCar() {
        Car *car = new Car{}; // Выделяем память под указатель car

        car->make = new char[20]{}; // Выделяем память под указатель make
        car->model = new char[20]{}; // Выделяем память под указатель model

        getchar();

        cout << "Enter car make: ";
        cin.getline(car->make, 20);

        cout << "Enter car model: ";
        cin.getline(car->model, 20);

        cout << "Enter car price: ";
        cin >> car->price;

        return *car;
    }

    void addCar() {
        if (carCount < carCapacity) {
            cars[carCount] = createCar();
            carCount++;
        }
        else {
            cout << "Showroom is full" << endl;
        }
    }

    void showAllCars() {
        for (size_t i = 0; i < carCount; i++) {
            cars[i].showCar();
        }
    }

};


int main() {

    Showroom* showroom = new Showroom{};

    while(true)
    {
        int choice{};
        cout
        << "Enter choice: " << endl
        << "1. Add car" << endl
        << "2. Show all cars" << endl;

        cin >> choice;

        switch (choice)
        {
        case 1:
            system("cls");
            showroom->addCar();
            break;
        case 2:
            system("cls");
            showroom->showAllCars();
            break;
        default:
            break;
        }
    }
    return 0;
}

#pragma endregion

