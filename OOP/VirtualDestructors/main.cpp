#include <iostream>
#include <string>

using namespace std;

#pragma region Part1

/*
class Person {
public:
    char* name = new char[] {"Elvin"};

    virtual ~Person() {
        cout << "Destructor of Person" << endl;
        delete[] name;
    }
};

class Student : public Person {
public:
    char* university = new char[] {"AzTU"};

    ~Student() override {
        cout << "Destructor of Student" << endl;
        delete[] university;
    }
};


int main() {

    Student* student = new Student();
    Person* person = student;

    delete person;

    return 0;
}
*/

#pragma endregion

#pragma region Part2

class Person {
public:
    char* name = new char[] {"Elvin"};
    virtual void print() = 0; // pure virtual method

    virtual ~Person() = 0;
};


class Student : public Person {
public:
    char* university = new char[] {"AzTU"};

    void print() override {
            cout << "print from student" << endl;
    }

    ~Student() override {
        cout << "Destructor of Student" << endl;
        delete[] university;
        delete[] name;
    }
};


int main() {

   Person* p1 = new Student();

   p1->print();

   cout << ((Student*)p1)->university << endl;


    return 0;
}

#pragma endregion



