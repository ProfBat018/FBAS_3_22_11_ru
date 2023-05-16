#include <iostream>

using namespace std;


int main() {

    // cin.ignore(); - берет все что вы ввели после ввода например числа и игнорирует его
    // Если я введу 2 и Enter он проигнорирует Enter

    // getchar(); - берет ввод и возвращает его ASCII значение,
    // при этом наш Enter не запишется в строку, а обработается уже самой функцией


    char *name{}, *surname{};
    int age{};

    name = new char[30]{};
    surname = new char[30]{};

    cout << "Enter name: " << endl;
    cin.getline(name, 30);

    cout << "Enter age: " << endl;
    cin >> age;

    cin.ignore();

    cout << "Enter surname: " << endl;
    cin.getline(surname, 30);


    return 0;
}
