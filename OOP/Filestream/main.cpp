#include <iostream> // для работы с потоками ввода/вывода
#include <string> // для работы со строками
#include <fstream> // для работы с файлами
#include <sstream> // string stream. для работы со строковыми потоками
#include <cstdint> // для работы с целыми числами

struct Date {
    uint16_t year;
    uint16_t month;
    uint16_t day;

    Date(uint16_t year, uint16_t month, uint16_t day) {
        this->year = year;
        this->month = month;
        this->day = day;
    }

    friend std::ostream& operator<<(std::ostream& os, const Date& date) {
        os << date.day << "/" << date.month << "/" << date.year;
        return os;
    }

    friend std::istream& operator>>(std::istream& is, Date& date) {
        is >> date.year >> date.month >> date.day;
        return is;
    }
};

class Person {
public:
    Person() = default;
    Person(std::string& name, std::string& surname, Date* birthday) {
        this->name = name;
        this->surname = surname;
        this->birthday = birthday;
    }

    friend std::ostream& operator<<(std::ostream& os, const Person& person) {
        os << person.name << "\t" << person.surname << "\t" << *person.birthday;
        return os;
    }

    friend std::istream& operator>>(std::istream& is, Person& person) {
        is >> person.name >> person.surname >> *person.birthday;
        return is;
    }
private:
    std::string name;
    std::string surname;
    Date* birthday;
};

int main() {
/*
     ofstream - output stream. Поток вывода в файл
     ios - input/output stream. Поток ввода/вывода
     out - output. Вывод
     in - input. Ввод
     app - append. Добавление в конец файла
     typedef - шаблон для типа данных
*/

#pragma region Write

//    std::ofstream file("data.txt", std::ios::out);
//
//    if (file.is_open()) {
//        file << "Hello World\nHello Vaqif\n";
//    }

#pragma endregion

#pragma region Read

//std::ifstream file("data.txt", std::ios::in);
//std::string text;
//
//if (file.is_open()) {
//    std::stringstream ss;
//    std::string line;
//    while (getline(file, line)) {
//        ss << line << "\n";
//    }
//    text = ss.str();
//}
//
//std::cout << text << std::endl;
//
#pragma endregion

#pragma region WriteClassToFile
std::string name = "Elvin";
std::string surname = "Azimov";

Date* d1 = new Date(2001, 11, 16);

Person* p1 = new Person(name, surname, d1);

std::ofstream file("data.txt", std::ios::app);

if (file.is_open()) {
    file << *p1 << "\n";
}

#pragma endregion



    return 0;
}
