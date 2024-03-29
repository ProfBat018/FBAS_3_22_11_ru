# Тема урока. Explicit ctors. Явные конструкторы.

# Для начала запомним одно правило. ***ВСЕ НЕЯВНОЕ - ПЛОХОЕ.*** Это относится только к строготипизированным языкам.


# Вспомним про конструкторы. 
1. Конструктор по умолчанию
2. Конструктор с параметрами 
3. Конструктор копирования
4. Конструктор перемещения (еще не рассматривали)

### Конструктор по умолчанию есть всегда
### Если мы определелили конструктор с параметрами, то конструктор по умолчанию не будет сгенерирован компилятором
### Конструктор копирования есть всегда

<br>
<br>
<br>

# Что такое explicit конструктор ?

### Explicit constructor - это конструктор, который не может быть вызван неявно.

Пример:
```cpp

class A 
{
public:
    A(int a) 
    {
        this-> a = a;
    }
private:
    int a;
};

int main() 
{
    A a = 5; // Неявный вызов. Заработает
    A a2(5); // Явный вызов. Заработает. По сути тоже самое
    A a3 = A(5); // Явный вызов. Заработает. По сути тоже самое. Не очень люблю писать
    A *a4 = new A(5); // Явный вызов. Заработает. По сути тоже самое. Не очень люблю писать

    return 0;
}
```

По сути в примере выше есть такой код

```cpp
A a = 5;
```

Я против такого написания, и не только я. Потому что с версии С++ 11 пришло много нововведений включая унифицированную инициализацию. Вообще без explicit и унифицированной инициализации в этом языке с конструкторами получается зоопарк. 

# Что плохого в неявном вызове конструктора ?

Предположим у меня есть шаблонная функция, которая принимает по ссылке объект моего класса. Давайте рассмотрим пример с таким кодом. 

```cpp
#include <iostream>
#include <string>
#include <cstdint>

using namespace std;

class Car
{
public:

    Car() {
        cout << "default constructor" << endl;
        this->make = "Mercedes";
        this->model = "C63 AMG";
        this->year = 2014;

    }

    Car(uint16_t year) {
        this->make = "Mercedes";
        this->model = "C63 AMG";
        this->year = year;
    }

    Car(string make, string model, uint16_t year)
    {
        this->make = make;
        this->model = model;
        this->year = year;
    }

    friend ostream& operator<<(ostream& os, const Car& car)
    {
        os << car.make << " " << car.model << " " << car.year;
        return os;
    }

private:
    string make;
    string model;
    uint16_t year;
};


template <typename T>
void print(T value)
{
    cout << value << endl;
}

int main()
{
    print<Car>({}); //  Это что за бред ?! неявно
     
    // Это тоже самое, что и предыдущая строка.
    // Но тут уже понятно, что мы создаем объект класса Car
    print<Car>(Car()); // явно

    return 0;
}

```


# Тут проблем несколько
1. Неявный вызов конструктора
2. Не читаемый код
3. Если, наш код будет запечатан в .dll, то пользователь сможет создавать объекты нашего класса, не зная, что это за класс.


# [Статья c habr](https://habr.com/ru/articles/436296/)
