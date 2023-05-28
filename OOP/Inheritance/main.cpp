#include <iostream>

using namespace std;

//class Person {
//protected:
//    string name;
//    string surname;
//    int age;
//public:
//    Person(string name, string surname, int age) {
//        this->name = name;
//        this->surname = surname;
//        this->age = age;
//    }
//};
//
//class Student : public Person {
//public:
//    float gpa;
//    Student(string name, string surname, int age, float gpa) : Person(name, surname, age) {
//        this->gpa = gpa;
//    }
//};


class Animal {
public:
    char *name;
    char *breed;
    int age;

    Animal(char *name, char *breed, int age) {
        this->name = name;
        this->breed = breed;
        this->age = age;
    }

    ~Animal() {
        cout << "Animal " << this->name << " is deleted" << endl;
        delete[] this->name;
        delete[] this->breed;
    }
};

int main() {

    if (true) {
        int a = 1;
        Animal* a1 = new Animal(new char[]{"Alisa"}, new char[]{"Siamese"}, 3);
        delete a1;

        Animal a2(new char[]{"Alisa"}, new char[]{"Siamese"}, 3);
    }


//    Student* baxa = new Student("Baxtiyar", "Mirzoyev", 17, 2.f);

//    Student baxa("Baxtiyar", "Mirzoyev", 17, 2.f);
//    Person p1 = baxa;




    return 0;
}

