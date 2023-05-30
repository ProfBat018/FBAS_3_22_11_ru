# Тема урока. Полиморфизм 

Полиморфизм - исходит от латинского слова "polymorphos", что означает "имеющий много форм".

В жизни я могу привести вам пример с водой.
У воды есть три агрегатных состояния: твердое, жидкое и газообразное.
При это важным аспектом является то, что это состояние зависимо от внешних факторов, как и в программировании.
Если вода из жидкости переходит в газ, то она не перестает быть водой 

Есть разные виды полиморфизма:
* `статический` - работает на этапе компиляции
* `динамический` - работает на этапе выполнения

### Что входит в статический полиморфизм ?
- `перегрузка методов` - методы с одинаковыми именами, но разными параметрами
- `перегрузка операторов` - операторы с одинаковыми именами, но разными параметрами
- `шаблоны функций` - функции с одинаковыми именами, но разными параметрами
- `шаблоны классов` - классы с одинаковыми именами, но разными параметрами

### Что входит в динамический полиморфизм ?
- `виртуальные функции` - функции, которые могут быть переопределены в классах наследниках
- `чисто виртуальные функции` - функции, которые должны быть переопределены в классах наследниках
- `виртуальный деструктор` - деструктор, который должен быть переопределен в классах наследниках


#### Давайте рассмотрим примеры кода для каждого вида полиморфизма.

## Перегрузка функций

```cpp

float add (float a, float b) {
    return a + b;
}

int add (int a, int b) {
    return a + b;
}

int main() {
    std::cout << add(1, 2) << std::endl;
    std::cout << add(1.0f, 2.0f) << std::endl;
    return 0;
}

```

## Перегрузка методов

```cpp

class Person {
public:
    void sayHello() {
        std::cout << "Hello" << std::endl;
    }

    void sayHello(std::string name) {
        std::cout << "Hello " << name << std::endl;
    }
}
```

## Перегрузка операторов
#include <iostream>
#include <string>

using namespace std;

class A {
int num1;
friend class B;
};

class B {
int num3;
A a;

    void foo() {
        a.num1 = 20;
    }
};


class Person {
private:
uint16_t age{};
public:
string name{};
string surname{};

    Person() = default;

    Person(string name, string surname, uint16_t age) {
        this->name = name;
        this->surname = surname;
        this->age = age;
    }

    bool operator>(const Person &other) const {
        return this->age > other.age;
    }

    bool operator<(const Person &other) const {
        return this->age < other.age;
    }

    bool operator==(const Person &other) const {
        return this->name == other.name && this->surname == other.surname && this->age == other.age;
    }

    bool operator!=(const Person &other) const {
        return this->name != other.name && this->surname != other.surname && this->age != other.age;
    }

    // ostream - output stream
    friend ostream& operator << (ostream& os, const Person& person) { // неявная функция
        os << person.name << " " << person.surname << " " << person.age << endl;
        return os;
    }

    friend istream& operator >> (istream& is, Person& person) { // неявная функция
        is >> person.name >> person.surname >> person.age;
        return is;
    }

};



int main() {

    Person *p1 = new Person("Amir", "Abdurahmanov", 16);
    Person *p2 = new Person("Elvin", "Azimov", 21);

//    cout << "p1 > p2: " << (*p1 > *p2) << endl;
//    cout << "p1 < p2: " << (*p1 < *p2) << endl;

    cout << "p1 == p2: " << (*p1 == *p2) << endl;
    cout << "p1 == p2: " << p1->operator==(*p2) << endl;

    cin >> *p1;
    cout << *p1;


    return 0;
}


Динамический полиморфизм мы рассмотрим подробно в следующем уроке, но сегодня будет спойлеры.

```c++

```


