#include <iostream>
using namespace std;


#pragma region Part1

/*
class Person {
    uint16_t age;
public:
    char *name;
    char *surname;

    // Getter
    uint16_t getAge() const{
        return this->age;
    }

    Person(uint16_t age, char *name, char *surname) {
        this->age = age;
        this->name = name;
        this->surname = surname;
    }

    // Non-mutable function
    void print() const {
        cout << "Name: " << name << endl;
        cout << "Surname: " << surname << endl;
        cout << "Age: " << age << endl;
    }
};


int main() {

    Person p1(20, new char[] {"John"}, new char[] {"Doe"});

    cout << p1.getAge();

    return 0;
}

 */
#pragma endregion

#pragma region Constructors
/*
class Person {
    uint16_t age;
public:
    Person() = default;
    Person(uint16_t age) {
        this->age = age;
    }
};

int main() {
    Person p1;
    Person p2(20);
}
*/
#pragma endregion

#pragma region Properties
/*
class Person {
private:
    uint16_t age;
public:
#pragma region Properties
    // Getter
    uint16_t getAge() const{
        return this->age;
    }

    // Setter
    void setAge(uint16_t age) {
        if (age > 18 && age <= 65)
        this->age = age;
        else
            cout << "Invalid age" << endl;
    }
#pragma endregion
    char* name{};
    char* surname{};

    Person() = default;

    Person(char* name, char* surname, uint16_t age) {
        this->name = name;
        this->surname = surname;
        this->age = age;
    }
};

int main() {
    Person* p1 = new Person(new char[] {"Elvin"}, new char[] {"Azimov"}, 21);

    cout << p1->getAge() << endl;

    p1->setAge(40);

    cout << p1->getAge() << endl;
}
*/
#pragma endregion