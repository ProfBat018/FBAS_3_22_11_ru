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