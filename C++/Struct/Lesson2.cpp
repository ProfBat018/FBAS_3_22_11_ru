#include <iostream>
#include "Person.h"

using namespace std;


// Так как Person - это тип данных, то его можно вернуть из функции. Например:

//Person createPerson() {
//    Person p1;
//
//    cin.ignore();
//    cout << "Enter name: ";
//    cin.getline(p1.name, 20);
//
//    cout << "Enter surname: ";
//    cin.getline(p1.surname, 20);
//
//    cout << "Enter age: ";
//    cin >> p1.age;
//
//    return p1;
//}


Person* createPerson() {
    Person* p1 = new Person;

    cout << "Enter name: ";
    cin.getline(p1->name, 20);

    cout << "Enter surname: ";
    cin.getline(p1->surname, 20);

    cout << "Enter age: ";
    cin >> p1->age;

    return p1;
}


int main()
{
    int count{};
    cout << "Enter count of persons: ";
    cin >> count;

    char a = getchar(); // Это нужно, чтобы cin не съел символ переноса строки.

    cout << a << endl;

    Person **persons = new Person*[count];

    for (int i = 0; i < count; i++) {
        persons[i] = createPerson();
    }

    for (int i = 0; i < count; i++) {
        persons[i]->print();
    }
}

