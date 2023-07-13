# Тема урока. Конструктор переноса

### Повтор. Какие конструкторы бывают ? 
* Конструктор по умолчанию
* Конструктор с параметрами
* Конструктор копирования
* Конструктор перемещения


## Конструктор по умолчанию

При объявлении любого другого конструктора, конструктор по умолчанию не генерируется компилятором. 
То есть также можно сказать что он удаляется. 

## Перегрузка конструкторов
Правила любой перегрузки. 

***Относится как к функциям, так и к конструкторам, и операторам.***

* По типу параметров
* По Количеству параметров
* По порядку параметров
* Нет перегрузки по возвращаемому значению

Что мы можем сделать дополнительно ?
1. Можно поставить параметр по умолчанию.
2. Можно явно удалить какой-то конструктор.
3. Можно делегировать конструкторы.

### Параметр по умолчанию
```cpp
class A
{
    int a;
    int b;
    int c;
public:
    A(int a = 0, int b = 0, int c = 0) 
    {
        this->a = a;
        this->b = b;
        this->c = c;
    }
};

A a;
```

### Явное удаление конструктора
```cpp
class A
{
    int a;
    int b;
    int c;
public:
    A(int a = 0, int b = 0, int c = 0) 
    {
        this->a = a;
        this->b = b;
        this->c = c;
    }
    A(const A&) = delete;
};
```

### Делегирование конструкторов
Делегирование конструкторов - это вызов одного конструктора из другого. 

```cpp
class Transport
{
    int speed;
    int weight;
public:
    // Transport(int speed, int weight) : speed(speed), weight(weight) {}
    Transport(int speed, int weight) 
    {
        this->speed = speed;
        this->weight = weight;
    }
};


class Car : public Transport
{
    int wheels;
public:
    Car(int speed, int weight, int wheels) : Transport(speed, weight)
    {
        this->wheels = wheels;
    }
};

Car car1(100, 2000, 4);
```

## Конструктор копирования и оператор присваивания

```c++
#include <iostream>
#include <string>
#include <cstring>

using namespace std;

class Car {

public:
    char* name;
    char* color;
    int price;
    Car() = default;

    Car(char* name, char* color, int price)
    {
        cout << "Constructor with parameters called!" << endl;
        this->name = name;
        this->color = color;
        this->price = price;
    }

    Car(const Car &other)
    {
        cout << "Copy constructor called!" << endl;

        strcpy(this->name, other.name);
        strcpy(this->color, other.color);
        this->price = other.price;
    }

    // ostream - output stream
    friend ostream& operator<<(ostream& out, const Car& car)
    {
        out << "Name: " << car.name << endl;
        out << "Color: " << car.color << endl;
        out << "Price: " << car.price << endl;
        return out;
    }
};

int main() {

    Car *c1 = new Car(new char[] {"BMW"}, new char[] {"Black"}, 10000);
    Car *c2 = new Car(*c1);

    c2->name[0] = 'A';

    cout << *c1 << endl;
    cout << *c2 << endl;


    return 0;
}

```

```c++

class Number {
private:
    int num;
public:
    explicit Number(int num)
    {
        this->num = num;
    }

    Number& operator=(const Number& other)
    {
        this->num = other.num;
        return *this;
    }
};

int main() {

    // Number n1(5);
    // Number n1 {5};

    Number n1(5);

    Number n2 = n1; // assignment operator. Оператор присваивания
    Number n3(n1); // copy constructor


    return 0;
}

```

## Конструктор перемещения 




