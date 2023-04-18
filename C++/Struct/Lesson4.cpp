#include <iostream>

using namespace std;


struct Person {
    char *name = new char[20]{};
    char *surname = new char[20]{}; // {} - это инициализация.
    int age;

    // Это конструктор. Он вызывается при создании объекта.
    // Конструктор по умолчанию.
    // Конструктор по умолчанию - это конструктор без параметров, он есть всегда.

    Person() {
        name = new char[]{"Elvin"};
        surname = new char[]{"Azimov"};
        age = 21;
    }

    // Конструкторы могут быть перегружены.
    // Конструктор с параметрами.
    Person(char *_name, char *_surname, int _age) {
        name = _name;
        surname = _surname;
        age = _age;
    }

    void print() {
        cout << name << " " << surname << " " << age << endl;
    }

};


Person createPerson() {
    char *name = new char[20]{};
    char *surname = new char[20]{};
    int age{};

    cout << "Enter name: ";
    cin.getline(name, 20);

    cout << "Enter surname: ";
    cin.getline(surname, 20);

    cout << "Enter age: ";
    cin >> age;

    Person *p = new Person(name, surname, age);
    return *p;
}

int main() {

//    Person p1;
//    p1.print();

    int length{};

    cout << "Enter length: ";
    cin >> length;

    Person *persons = new Person[length];

    for (int i = 0; i < length; i++) {
        getchar();
        persons[i] = createPerson();
    }

    for (int i = 0; i < length; ++i) {
        persons[i].print();
    }


    return 0;
}