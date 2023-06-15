#pragma region Incapsulation

/*
#include <iostream>
#include <cstdint>
#include <string>

using namespace std;

// Инкапсуляция. Это про предоставление доступа к данным
// Наследование
// Полиморфизм

struct RAM {
    RAM() = default;

    // RAM(uint16_t size, uint16_t frequency) : size(size), frequency(frequency) {}

    RAM(uint16_t size, uint16_t frequency) {
        this->size = size;
        this->frequency = frequency;
    }

private:
    uint16_t size;
    uint16_t frequency;
};


struct Motherboard {
    Motherboard(uint16_t ramSlots, uint16_t pciSlots) {
        this->ramSlots = ramSlots;
        this->pciSlots = pciSlots;
    }

public:
    void setRAM(RAM *ram) {
        bool check = true;
        for (int i = 0; i < this->ramSlots; ++i) {
            if (this->rams[i] == nullptr) {
                this->rams[i] = ram;
                check = false;
                cout << "RAM installed" << endl;
                break;
            }
        }
        if (check) {
            cout << "No free slots" << endl;
        }
    }

    RAM **getRAM() {
        return rams;
    }

    RAM **rams = new RAM *[ramSlots]{};
private:
    uint16_t ramSlots;
    uint16_t pciSlots;

};

class Laptop {
public:
    Motherboard *motherboard{};

    Laptop(const string &make, const string &model, Motherboard *motherboard) {
        this->motherboard = motherboard;
    }

private:
    string make;
    string model;
};


int main() {

    Laptop *asus = new Laptop(new char[]{"Asus"}, new char[]{"ROG G531-GT"}, new Motherboard(2, 1));

    asus->motherboard->setRAM(new RAM(16, 3200));
    asus->motherboard->setRAM(new RAM(16, 3200));
    asus->motherboard->setRAM(new RAM(16, 3200));


    return 0;
}
*/
#pragma endregion

#pragma region Inheritance

/*
#include <iostream>
#include <cstdint>

using namespace std;

class Component
{
public:
    Component() = default;

    Component(const string &make, const string &model)
    {
        this->make = make;
        this->model = model;
    }

    string getMake()
    {
        return make;
    }

    string getModel()
    {
        return model;
    }

protected:
    string make;
    string model;
};

struct RAM : public Component
{
    RAM() = default;
    RAM(const string &make, const string &model, uint16_t size, uint16_t frequency)
    : Component(make, model)
    {
        this->size = size;
        this->frequency = frequency;
    }

private:
    uint16_t size;
    uint16_t frequency;

    string make;
    string model;
};

struct Motherboard : public Component
{
    Motherboard(const string &make, const string &model, uint16_t ramSlots, uint16_t pciSlots)
    : Component(make, model)
    {
        this->ramSlots = ramSlots;
        this->pciSlots = pciSlots;
    }

public:
    void setRAM(RAM *ram)
    {
        bool check = true;
        for (int i = 0; i < this->ramSlots; ++i)
        {
            if (this->rams[i] == nullptr)
            {
                this->rams[i] = ram;
                check = false;
                cout << "RAM installed" << endl;
                break;
            }
        }
        if (check)
        {
            cout << "No free slots" << endl;
        }
    }

    RAM **getRAM()
    {
        return rams;
    }

    RAM **rams = new RAM *[ramSlots] {};

private:
    uint16_t ramSlots;
    uint16_t pciSlots;
};

class Laptop
{
public:
    Motherboard *motherboard{};

    Laptop(const string &make, const string &model, Motherboard *motherboard)
    {
        this->motherboard = motherboard;
    }

private:
    string make;
    string model;
};


int main()
{


    return 0;
}
*/

#pragma endregion

#pragma region Polymorphism

#include <iostream>
#include <cstdint>

using namespace std;

// стал абстрактным классом
class Transport 
{
public:
    Transport() = default;

    Transport(const string &make, const string &model)
    {
        this->make = make;
        this->model = model;
    }

    virtual string getMake() = 0;
    virtual string getModel() = 0;

protected:
    string make;
    string model;
};

class Car : public Transport {
public:
    Car() = default;

    Car(const string &make, const string &model, const string &color)
    : Transport(make, model) {
       this->color = color;
    }

    string getMake() override {
        cout << "Car getMake" << endl; // "Car getMake
        return this->make;
    }

    string getModel() override {
        cout << "Car getModel" << endl; // "Car getModel
        return this->model;
    }
private:
    string color;
};

int main () {

    Transport *t1 = new Car("BMW", "X5", "Black");


    return 0;
}

#pragma endregion
