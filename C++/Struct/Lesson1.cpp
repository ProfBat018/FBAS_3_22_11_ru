#include <iostream>

using namespace std;


/*
  Пользовательские типы данных - enum, struct, class
    enum - перечисление от слова enumeration
    struct - структура
    class - класс
    В С++ классы и структуры почти одинаковы, но есть некоторые отличия.
    В С классов нет, а структура вообще не такая как в С++.


  Перечисление - это пользовательский тип, который по факту просто является набором из const int.
  То есть вы просто создаете тип, который объединяет в себе несколько констант.


  Структуры - это пользовательские типы данных,
  которые позволяют хранить в себе данные разных типов.

  ______________________________________________
  Переменные в структуре называются полями.
  Функции в структуре называются методами.
  ______________________________________________

*/

#pragma region Enum

/*
// Перечисление
enum Color {
    RED = 1,
    GREEN,
    BLUE
};

int main() {

    // P.S. Не забывайте инициализировать переменные!

    while (true) {

        int choice{}; // Переменная для выбора цвета

        cout
                << "Enter color: " << '\n'
                << "1 - RED" << '\n'
                << "2 - GREEN" << '\n'
                << "3 - BLUE" << '\n';

        cin >> choice;

        switch (choice) {
            case Color::RED:
                cout << "RED" << '\n';
                break;
            case Color::GREEN:
                cout << "GREEN" << '\n';
                break;
            case Color::BLUE:
                cout << "BLUE" << '\n';
                break;
            default:
                cout << "Unknown color" << '\n';
                break;
        }
    }

    return 0;
}
 */
#pragma endregion


#pragma region Struct

#include <iostream>
#include "Person.h"

using namespace std;




int main() {
    /*
     Глава 1.
     1. Что такое ООП ?
     2. Зачем нам нужны структуры ?
     3. Процедурное программирование vs ООП
     4. Как считать размер структуры ?

     ООП - Объектно-Ориентированное Программирование.
     Для нас главным является объект.

     1. Структура - это пользовательский тип данных, который позволяет хранить в себе данные разных типов.
     2. Структуру надо создавать вне main. По сути это просто тип данных, который создали вы.
     3. По хорошему, структуру надо создавать в отдельном файле, а в main или где то в другом только использовать.
     */

/*
    Person p1;

    p1.name = new char[] {"Elvin"};
    p1.surname = new char[] {"Azimov"};
    p1.age = 21;

    cout << p1.name << " " << p1.surname << " " << p1.age << endl;
*/

/*

Предположим, мне надо хранить массив из людей. Например сдуентов. Как это сделать ?
По старому методу, вы бы создали 3 массива.

Первый массив - это массив имен.
Второй массив - это массив фамилий.
Третий массив - это массив возрастов.

По новому методу, вы бы создали массив структур.
 Например:

 */

    Person students[3];

    students[0].name = new char[]{"Elvin"};
    students[0].surname = new char[]{"Azimov"};
    students[0].age = 21;

    students[1].name = new char[]{"Famil"};
    students[1].surname = new char[]{"Qaraxanli"};
    students[1].age = 15;

    students[2].name = new char[]{"Isa"};
    students[2].surname = new char[]{"Ismayilov"};
    students[2].age = 15;


    for (int i = 0; i < 3; i++) {
        students[i].print();
    }

    /*
    В данном случае students - это массив структур.
    students[i] -  это массив из объектов структуры.
    Переменная, которая хранит структуру называется объектом.

     print() - это функция, которая находится внутри структуры.
     так как функция находится внутри структуры, то она называется методом.
     ее можно вызвать только через объект структуры.
    */


    return 0;
}


#pragma endregion