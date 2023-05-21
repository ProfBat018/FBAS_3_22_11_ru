#include <iostream>

using namespace std;

class MyString {
private:
    char *str{};
    uint16_t length{};
    uint16_t capacity{16};
public:
    MyString() {
        this->str = new char[capacity]{};
    }
    MyString(const char* data) {
        this->length = strlen(data); // беру длину строки

        while(this->length >= capacity) {
            capacity *= 2;
        }
        this->str = new char[capacity]{};

        strcpy_s(this->str, this->length + 1, data); // копирую строку
    }

    void append(const char* data) {
        uint16_t dataLength = strlen(data);
        uint16_t newLength = this->length + dataLength;

        while(newLength >= capacity) {
            capacity *= 2;
        }

        char* newStr = new char[capacity]{};

        strcpy_s(newStr, this->length + 1, this->str);
        strcpy_s(newStr + this->length, dataLength + 1, data);

        delete[] this->str;
        this->str = newStr;
        this->length = newLength;
    }

    void print() {
        cout << this->str << endl;
    }
};

int main() {

    MyString name = "Elvin"; // MyString name("Elvin");

    name.print();

    name.append("Azimov");

    name.print();

    return 0;
}
