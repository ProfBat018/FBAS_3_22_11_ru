#pragma region Part1

/*
#include <iostream>
using namespace std;


int main() {

#pragma region Write

    FILE* file{};

    char* name = new char[]{"Elvin"};

    fopen_s(&file, "data.txt", "w"); // открываю файл для записи

    if (file == nullptr) {
        cout << "Error" << endl;
    }

    fprintf(file, "%s\n", name);

    if (file != nullptr)
        fclose(file);


#pragma endregion


#pragma region Read

    FILE* file{};

    fopen_s(&file, "data.txt", "r"); // открываю файл для чтения

    if (file == nullptr) {
        cout << "Error" << endl;
    }

    char* name = new char[30]{};

    fscanf_s(file, "%s", name, 30);

    cout << name << endl;


    return 0;
}
*/
#pragma endregion

#pragma region Part2

/*
    Написать программу, которая вводит имена. Каждое имя записывается в файл "names.txt"
    Реализовать:
    1. Добавление имени
    2. Вывод всех имен из файла
*/

#include <iostream>
#include <Windows.h>

#define NAMES_COUNT 100
#define NAME_LENGTH 30
using namespace std;

void addName();

char **getNames();

int main() {

    int choice{};

    while (true) {
        cout << "Enter choice:\n"
                "1. Add name\n"
                "2. Get names\n"
                "3. Exit\n";

        cin >> choice;

        switch (choice) {
            case 1: {
                addName();
                break;
            }
            case 2: {
                system("cls");
                char **names = getNames();

                for (int i = 0; i < NAMES_COUNT; ++i) {
                    if (names[i] == nullptr) {
                        break;
                    }
                    cout << i + 1 << '.' << names[i] << endl;
                }
                break;
            }
            case 3:
                return 0;
        }
    }
}


void addName() {
    char **names = new char *[NAMES_COUNT]{};

    int i{};
    cin.ignore();


    while (true) {

        char *name = new char[NAME_LENGTH]{};
        cout << "Enter name: ";


        cin.getline(name, NAME_LENGTH);

        names[i] = name;

        if (GetAsyncKeyState(VK_ESCAPE)) {
            break;
        }
        i++;
    }

    FILE *file{};

    fopen_s(&file, "names.txt", "a");

    if (file == nullptr) {
        cout << "Error" << endl;
        return;
    }


    // 1 способ
    for (int j = 0; j < i; ++j) {
        fprintf(file, "%s\n", names[j]);
    }

    // 2 способ
    // for (int j = 0; j < i; ++j) {
    //      fputs(names[j], file);
    //      fputs("\n", file);
    // }

    fclose(file);
}


char **getNames() {
    char **names = new char *[NAMES_COUNT]{};

    FILE *file{};
    fopen_s(&file, "names.txt", "r");

    int i{};

    while (!feof(file)) {
        char *name = new char[NAME_LENGTH]{}; // выделяю память под имя
        fscanf_s(file, "%s", name, NAME_LENGTH);
        names[i] = name;
        i++;
    }

    fclose(file);

    return names;
}

#pragma endregion