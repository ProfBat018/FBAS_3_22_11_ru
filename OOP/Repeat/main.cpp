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
