# Урок №3. Введение в ООП. Инкапсуляция

## Инкапсуляция - это один из главных принципов ООП.
Для его реализации существует много разных механизмов, из-за этого давайте рассмотрим все на однос большом примере.

Инкапсуляция - это механизмы управления доступом к данным, но ни в коем случае не сокрытие.

По факту разное предоставление доступа, это всего лишь путь к защите и легкому управлению этими данными.

Для того чтобы его реализовать нам нужно знать несколько ключевых слов, но без логичного использования они не предоставляют никакой инкапсуляции.


### Ключевые слова:
- `public` - все данные и методы доступны из любого места программы
- `private` - все данные и методы доступны только внутри класса
- `protected` - все данные и методы доступны из любого места программы, но только внутри класса и его наследников
- `const` - константа, если писать после метода ил, то данные не смогут изменяться
- `static` - статический метод или данные, они принадлежат сущности, а не объекту
- `final` (пройдем позже)
- `abstract` (пройдем позже)
- `virtual` (пройдем позже)

```c++
#include <iostream>
#include <string>

using namespace std;


enum Stage {
    NONE,
    STAGE1,
    STAGE2,
    STAGE3
};

struct Date {
private:
    uint16_t month;
    uint16_t day;
    uint16_t year;
public:
    Date(uint16_t day, uint16_t month, uint16_t year) {
        this->day = day;
        this->month = month;
        this->year = year;
    }

    string getDate() const {
        // to_string() конвертирует число в строку
        // + - конкатенация строк  (соединение строк)
        string res = to_string(this->day) + "/" + to_string(this->month) + "/" + to_string(this->year);
        return res;
    }
};

class Car {
private:
    string make;
    string model;
    Date *productionDate; // тут мы используем структуру Date, которую сами же создали
    Stage tuningStage = Stage::NONE; // по умолчанию на машине не тюнинга
    uint16_t horsePower;
public:
    Car(string make, string model, Date *productionDate, uint16_t horsePower) {
        this->make = make;
        this->model = model;
        this->horsePower = horsePower;

        if (&productionDate != nullptr) {
            this->productionDate = productionDate;
        }
        this->productionDate = productionDate;
    }

    string getModel() const {
        return this->model;
    }

    Date *getProductionDate() const {
        return this->productionDate;
    }

    void tuneCar() { // tuneCar - это сложный setter который по сути будет менять и horsepower и tuning stage
        cout << "Your current car stage is: " << this->tuningStage << endl;

        int selection{};

        cout << "Select tuning stage: " << endl;
        cout << "1. Stage 1" << endl;
        cout << "2. Stage 2" << endl;
        cout << "3. Stage 3" << endl;

        cin >> selection;


        if (selection == this->tuningStage + 1) {
            switch (selection) {
                case 1:
                    this->horsePower += 50;
                    this->tuningStage = Stage::STAGE1;
                    break;
                case 2:
                    this->horsePower += 100;
                    this->tuningStage = Stage::STAGE2;
                    break;
                case 3:
                    this->horsePower += 150;
                    this->tuningStage = Stage::STAGE3;
                    break;
            }
        }
        else {
            cout << "You can't tune your car to this stage" << endl;
        }

    }

    void print(){
        system("cls");
        cout << "Make: " << this->make << endl;
        cout << "Model: " << this->model << endl;
        cout << "Horsepower: " << this->horsePower << endl;
        cout << "Production date: " << this->productionDate->getDate() << endl;
        cout << "Tuning stage: " << this->tuningStage << endl;
    }

};


int main() {

    Date date(1, 1, 2021); // явный вызов конструктора
    Date date1{1, 1, 2021}; // унифицированный вызов конструктора
    Date *date2 = new Date(1, 1, 2021); // явный вызов конструктора
    Date *date3 = new Date{1, 1, 2021}; // унифицированный вызов конструктора

    Car *car = new Car("Mercedes", "S600", new Date(1, 5, 2023), 550);

    car->print();
    car->tuneCar();

    _sleep(2000);
    car->print();
    car->tuneCar();

    _sleep(2000);
    car->print();
    car->tuneCar();

    _sleep(2000);
    car->print();
    car->tuneCar();

    car->print();

    return 0;
}

```