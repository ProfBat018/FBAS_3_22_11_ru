#include <iostream>
#include <string>

using namespace std;

/*
1.final
2.Библиотека algorithms
3.Исключения ???
4.ключевое слово explicit
5.виртуальные и чистые виртуальные методы и деструкторы
6.stack
7.дружественные классы и методы
8.queue
9.STL библиотека
10.Еще агрегация композиция
*/

#pragma region Final

// final - это тоже самое что и sealed в C#, а слово sealed означает запечатанный класс

/*
class Transport final {
public:
    string make;
    string model;
};

class Car : public Transport {
public:
    string color;
};

*/
#pragma endregion

#pragma region Algorithms

//#include <iostream>
//#include <algorithm>
//#include <string>
//#include <vector>
//
//using namespace std;

//// императивность - это написание алгоритма
//// декларативность - это описание алгоритма

//int main()
//{

//    vector<int> v = { 1, 2, 3, 4, 5 };

//// напишем логику для поиска элемента в векторе

//// императивный подход
//    for (int i = 0; i < v.size(); i++)
//    {
//        if (v[i] == 3)
//        {
//            cout << "Found" << endl;
//        }
//    }

//// декларативный подход

//    bool res = find(v.begin(), v.end(), 3) != v.end();
//
//    if (res)
//    {
//        cout << "Found" << endl;
//    }

//vector<int> v = {5, 3, 8, 1, 8, 9, 2, 4, 7, 6};

//// сортировка по императивному подходу

//for (int i = 0; i < v.size(); i++)
//{
//    for (int j = 0; j < v.size(); j++)
//    {
//        if (v[i] < v[j])
//        {
//            int temp = v[i];
//            v[i] = v[j];
//            v[j] = temp;
//        }
//    }
//}

//// сортировка по декларативному подходу
//sort(v.begin(), v.end());

//    return 0;
//}


#pragma endregion

#pragma region Exceptions

// Exceptions - исключения. Они нужны для того чтобы программа не завершала свою работу при ошибке
/*

class Transport {
public:
    string make;
    string model;

    void foo() {
        throw out_of_range("Out of range exception");
    }
};

int main() {

    Transport t;

    try {
        t.foo();
    }
    catch (exception& ex) {
        cout << ex.what() << endl;
    }

    cout << "End of program" << endl; // "End of program

    return 0;
}
 */

#pragma endregion

#pragma region Explicit

// ЗАПОМНИТЕ!!! Все что неявно - плохо
/*
class MyNum {
public:
    int num;

    explicit MyNum(int num) {
        this->num = num;
    }
};

void foo(MyNum a) {

}

int main() {

    foo(5);

//    MyNum a(5);

//    MyNum num(5); // явный вызов конструктора
//    MyNum num2 = 5; // неявный вызов конструктора

    return 0;
}
*/
#pragma endregion

#pragma region Virtual
/*
struct Transport {
    string make;
    string model;

    virtual void Move() {
        cout << "Transport moves" << endl;
    }

    virtual void Move2() = 0;
};

class Car : public Transport {
public:
    string color;

    void Move() override {
        cout << "Car moves" << endl;
    }

    void Move2() override {
        cout << "Car moves" << endl;
    }
};
*/
//int main() {
    /*
    Transport* t = new Transport();
    Car* c = new Car();
    Transport* tc = new Car();

    t->Move();  // Transport moves
    c->Move();  // Car moves
    tc->Move(); // Transport moves
    */

    /*
    Transport* t = new Transport();
    Car* c = new Car();
    Transport* tc = new Car();

    t->Move();  // Transport moves
    c->Move();  // Car moves
    tc->Move(); // Car moves
    */

//    Transport* t1 = new Car();

//}
#pragma endregion

#pragma region Stack

// Stack - очередь, которая работает по LIFO.
// LIFO - last in first out. Последний пришел - первый ушел
// По сути это всего лишь закрытый в классе массив.

/*
class MyStack {
private:
    int* arr{};
    int size{};
    int capacity{};
public:
    MyStack() {
        this->capacity = 10;
        this->size = 0;
        this->arr = new int[this->capacity]{};
    }

    int pop() {
        if (this->size == 0) {
            throw out_of_range("Stack is empty");
        }
        return this->arr[--this->size];
    }

    void add(int value) {
        if (this->size == this->capacity) {
            throw out_of_range("Stack is full");
        }
        this->arr[this->size++] = value;
    }
};
*/

// 1, 2, 3, 4, 5

// peek - 5
// 1, 2, 3, 4, 5
// peek - 4
// 1, 2, 3, 4, 5
// peek - 3
// 1, 2, 3, 4, 5
// peek - 2

#pragma endregion

#pragma region Friend
/*
class A {
    private:
    int a;
    int b;
    friend class B;
public:
   friend ostream& operator <<(ostream& os, A& a) {
        os << a.a << " " << a.b;
        return os;
    }
};

class B {
public:
    int num;
    void foo() {
        A a;
        a.a = 5;
        a.b = 10;
    }
};

ostream& operator <<(ostream& os, B& b) {
    os << b.num;
    return os;
}


int main() {

    A a;

    cout << a;

    return 0;
}
 */
#pragma endregion

#pragma region AggregationAndComposition

// Aggregation - это когда один объект содержит в себе другой объект
// Composition - это когда один объект является частью другого объекта

class Engine {
public:
    Engine(int n) {}
private:
    int num;
};

// Aggregation
class Car {
public:
    Engine* engine;

    Car() = default;
    Car(Engine* engine) {
        this->engine = engine; // composition
    }
};


// Composition
/*
class Car {
public:
    Engine* engine;
    Car(Engine* engine) {
        this->engine = engine; // composition
    }

    ~Car() {
        delete this->engine;
    }
};
*/
#pragma endregion

