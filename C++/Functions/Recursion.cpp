#pragma region Part1

//#include <iostream>
//
//using namespace std;
//
//int fact(int num) {
//    if (num == 1)
//        return 1;
//    return num * fact(num - 1);
//}
//
//int main() {
//    int res = fact(5);
//    cout << res;
//}
//
//
//
#pragma endregion

#include <iostream>
#include <ctime>

using namespace std;


void findMin(int *arr, int &min, int i) {
    if (i == 10) {
        return;
    }
    if (arr[i] < min) {
        min = arr[i];
    }
    findMin(arr, min, i + 1);
}

int main() {

    srand(time(NULL)); // создаю опору для случайных чисел.
    int min{}; // Создаю переменную, где буду хранить минимум

    int *arr = new int[10]{}; // Создаю динамический массив на 10 элементов.

    // Втсавляю туда рандомные числа
    for (int i = 0; i < 10; ++i) {
        arr[i] = rand() % 10 + 1;
    }

    min = arr[0]; // ВАЖНО!!! После инициализации записываю первый элемент в минимум.

    findMin(arr, min, 1);

    for (int i = 0; i < 10; ++i) {
        cout << arr[i] << ' ';
    }
    cout << endl;

    cout << min << endl;

    return 0;
}