#include <iostream>
#include <cstring>
#include <string>

using namespace std;

// Move constructor
// Move assignment operator
// memcpy - копирует данные из одного буфера в другой, он работает быстрее чем цикл for
// strlen - находит длину строки без \0. Elvin



class String {
    char* data; // Данные строки
    size_t size; // Размер строки

public:
    // String name = "Elvin";
    String(const char* data) {
        cout << "Constructor" << endl;
        this->size = strlen(data) + 1;
        this->data = new char[size]{};

        memcpy(this->data, data, this->size);
    }

    String(const String& other) {
        cout << "Copy constructor" << endl;
        this->size = other.size;
        this->data = new char[size]{};
        memcpy(this->data, other.data, this->size);
    }

    String(String&& other) {
        cout << "Move constructor" << endl;
        this->size = other.size;
        this->data = new char[size]{};
        memcpy(this->data, other.data, this->size);

        other.size = 0;
        other.data = nullptr;
    }

    String& operator=(const String& other) {
        if (this != &other) {
            delete[] data;
            this->size = other.size;
            this->data = new char[size]{};
            memcpy(this->data, other.data, this->size);
        }
        return *this;
    }

    String& operator=(String&& other) {
        if (this != &other) {
            delete[] data;
            this->size = other.size;
            this->data = new char[size]{};
            memcpy(this->data, other.data, this->size);

            other.size = 0;
            other.data = nullptr;
        }
        return *this;
    }

    ~String() {
        delete[] data;
    }

    friend ostream& operator<<(ostream& os, const String& str) {
        os << str.data;
        return os;
    }

    // Перегрузка оператора []
    // size_t - unsigned long long int

    char& operator[](size_t index) {
        return this->data[index];
    }
};

int main() {

    String name = "Elvin";
    String name2 = name;
    String name3 = move(name);


    cout << name2[0] << endl;
    cout << name2 << endl;
    cout << name3 << endl;
    cout << name << endl;


    return 0;
}
