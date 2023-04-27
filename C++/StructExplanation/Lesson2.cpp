#include <iostream>

using namespace std;

/*
    Структура - это тип данных, описанный вами.
    Использование типов данных по умолчанию не должно быть частым.
    Это усложняет код, как семантически, так и с точки производительности.

    Семантика - это то, как вы понимаете и используете данные. (больше про понимание)
    Производительность - это то, как быстро работает ваш код. (больше про быстроту)

    Структура состоит из полей (fields) и методов (methods).
    Поля - это переменные, которые хранят данные.
    Методы - это функции, которые могут использовать и изменять данные.

    Переменная типа вашей структуры называется объектом (object).
*/

/*
Главные принципы ООП:
 1. Инкапсуляция (Encapsulation) - это способность не просто скрывать данные, а манипулировать их доступом.
 2. Наследование (Inheritance) - это способность структуры наследовать данные и методы от других структур.
 3. Полиморфизм (Polymorphism) - это способность структуры иметь разные формы.
*/

/*
    Правило!!!
    Не храните большие сущности в stack.
    Всегда считайте объем памяти, который вы используете.
*/

/*
    Сейчас мы будем писать свой List, как в пайтоне.
    Но он будет работать только с конкретным типом данных.

    Какая разница между массивом и списком ?

    Массив - это последовательность элементов одного типа.
    Список - это не обязательно последовательность элементов одного типа.

    Список хранит указатели на каждый следующий элемент.

    Сейчас мы по сути сделаем свой vector.
*/

#pragma region Vector
//
//#include <vector>
//
//int main() {

    /*
        Вектор - это динамический массив.
        Он может изменять свой размер.
        Вектор хранит данные в памяти подряд.
        Вектор хранит указатели на каждый следующий элемент.


        Как работает capacity.

        Формула в visual c++: capacity = capacity + (capacity / 2);
        Формула в gcc: capacity = capacity * 2;
    */

    // Создаем вектор, который хранит int.
   /*
    vector<int> vec { 1, 2 };


    cout << "Capacity: " << vec.capacity() << endl;

    for (int i = 0; i < vec.size(); ++i) {
        cout << vec[i] << ' ';
    }
    cout << endl;

    vec.insert(vec.begin() + 2, 6);

    for (int i = 0; i < vec.size(); ++i) {
        cout << vec[i] << ' ';
    }

    cout << endl;

    cout << "Capacity: " << vec.capacity() << endl;

    vec.insert(vec.begin() + 3, 6);
    vec.insert(vec.begin() + 4, 6);

    cout << "Capacity: " << vec.capacity() << endl;

    vec.insert(vec.begin() + 5, 6);
    vec.insert(vec.begin() + 6, 6);
    vec.insert(vec.begin() + 7, 6);
    vec.insert(vec.begin() + 8, 6);
    vec.insert(vec.begin() + 9, 6);
    vec.insert(vec.begin() + 10, 6);

    cout << "Capacity: " << vec.capacity() << endl;


    return 0;
}
*/
#pragma endregion

#pragma region OwnVector
/*
   template <typename T>
   struct MyVector
   {
       struct Node {
              T data;
              Node* next;
       };
         Node* head = new Node;

         MyVector(initializer_list<T> values) {
             Node* current = head;

             for(auto it = values.begin(); it != values.end(); ++it) {
                 current->data = *it;
                 current->next = new Node;
                 current = current->next;
             }
             current->next = nullptr;
         }

         void print() {
             Node* current = head;
             while(current->next != nullptr) {
                 cout << current->data << ' ';
                 current = current->next;
             }
             cout << endl;
         }
   };

   int main()
   {
       // {} - это унифицированная инициализация, если элемент один.
       // {1, 2, 3, 4, 5} - это список инициализации, если элементов больше одного

        MyVector<int> vec {1, 2, 3, 4, 5 };
        vec.print();


       return 0;
   }
*/
#pragma endregion




