#include <iostream>

using namespace std;

// int - 4 bytes. range from -2 147 483 648 to 2 147 483 647
// uint - 4 bytes. range from 0 to 4 294 967 295
// enum - range задете вы.

enum Color {
    RED = 1,
    GREEN = 2,
    BLUE = 3,
    BLACK = 4,
    WHITE = 5
};

void showColor(Color selectedColor) {
    switch (selectedColor) {
        case RED:
            cout << "Red" << endl;
            break;
        case GREEN:
            cout << "Green" << endl;
            break;
        case BLUE:
            cout << "Blue" << endl;
            break;
        case BLACK:
            cout << "Black" << endl;
            break;
        case WHITE:
            cout << "White" << endl;
            break;
    }
}

struct Car {
    char *make;
    char *model;
    float price;
    Color carColor;

    void showCar() {
        cout << "Make: " << make << endl;
        cout << "Model: " << model << endl;
        cout << "Price: " << price << endl;
        cout << "Color: ";
        showColor(carColor);
    }
};


Color selectColor() {
    int colorSelection{};

    cout << "Select color: " << endl;
    cout << "1. Red" << endl;
    cout << "2. Green" << endl;
    cout << "3. Blue" << endl;
    cout << "4. Black" << endl;
    cout << "5. White" << endl;

    cin >> colorSelection;

    if (colorSelection > 0 && colorSelection < 6) {
        return (Color) colorSelection; // преобразование типа int в enum Color
    } else {
        cout << "Enter correct color!" << endl;
        selectColor();
    }
}


Car createCar() {
    Car car; // создаю объект структуры Car

    car.make = new char[20]{}; // выделяю память под указатель make
    car.model = new char[20]{}; // выделяю память под указатель model

    cout << "Enter make: ";
    cin.getline(car.make, 20); // Mercedes

    cout << "Enter model: ";
    cin.getline(car.model, 20); // CLS63

    cout << "Enter price: ";
    cin >> car.price; // 150000

    car.carColor = selectColor(); // Выбираю цвет машины

    return car;
}

int main() {

    Car c1 = createCar();
    c1.showCar();


    return 0;
}

