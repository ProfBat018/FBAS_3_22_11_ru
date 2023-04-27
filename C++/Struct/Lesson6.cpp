#include <iostream>
using namespace std;

// Как не надо делать :)
#pragma region Part1
/*
struct Person
{
    char* name = new char[20]{"Elvin"};
    int age{};
};

int main()
{
    Person p1; // name инициализируется первый раз

    cout << p1.name << endl;
    p1.name = new char[20]{"Baxtiyar"}; // name инициализируется второй раз
    cout << p1.name << endl;

    return 0;
}

 */

#pragma endregion

#pragma region Part2


#include <iostream>
#include <vector>

/*
    что такое vector ?
    Это обычный динаимический массив, который умеет сам расширяться
    то есть при добавлении элемента в конец массива, если в массиве не хватает места,
    то он создает новый массив большего размера и копирует в него все элементы из старого массива

    В обычном массиве мы не можем добавлять элементы в конец массива,
    мы можем только перезаписывать элементы
*/

using namespace std;

struct Student {
    char* name{};
    int age{};
    vector<float> marks{}; // здесь не надо создавать указатель и т.д.
};

int main()
{
    vector<int> numbers{1, 2, 3, 4, 5}; // создаем вектор с 5 элементами

    for (int i = 0; i < numbers.size(); ++i) {
        cout << numbers[i] << ' ';
    }
    cout << endl;

    numbers.push_back(6); // добавляем элемент в конец вектора

    for (int i = 0; i < numbers.size(); ++i) {
        cout << numbers[i] << ' ';
    }

    return 0;
}
#pragma endregion

