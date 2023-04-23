# Что такое структура и зачем она нужна ?

Структура - это пользовательский тип данных, 
который мы создаем для упрощенного хранения и обработки данных. 
<br>

Упрощенное хранение реализовано за счет того, что каждый объект состоит из полей и методов,
вместо обращения к каждому элементу массива, мы обращаемся к полю объекта.
<br>

Пример структуры 
```c++
struct Student {
    string name;
    int age;
    int group;
    int rating;
};

student.name = "Ivan";
student.age = 18;
student.group = 1;
student.rating = 5;
```

Пример без структуры
```c++
char* name = new char {"Ivan"};
int age = 18;
int group = 1;
int rating = 5;
```

При этом если студентов будет много, то придется создавать много переменных,
а если мы хотим хранить информацию о студентах в массиве, то придется создавать массивы для каждого поля.
<br>

Пример массива структур
```c++
struct Student {
    string name;
    int age;
    int group;
    int rating;
};

Student students[10];
students[0].name = "Ivan";
students[0].age = 18;
students[0].group = 1;
students[0].rating = 5;
```

Пример массива без структуры
```c++
char* names[10] = new char[10] {"Ivan"};
int ages[10] = {18};
int groups[10] = {1};
int ratings[10] = {5};
```

Упрощенная обработка реализована за счет того, что мы можем создать методы для структуры,
которые будут выполнять какие-то действия над данными структуры.

Пример метода
```c++
struct Student {
    string name;
    int age;
    int group;
    int rating;
    
    void print() {
        cout << "Name: " << name << endl;
        cout << "Age: " << age << endl;
        cout << "Group: " << group << endl;
        cout << "Rating: " << rating << endl;
    }
};

Student student;
student.name = "Ivan";
student.age = 18;
student.group = 1;
student.rating = 5;

student.print();
```

Вывод:
```
Name: Ivan
Age: 18
Group: 1
Rating: 5
```

Пример без метода
```c++

void print(char* name, int age, int group, int rating) {
    cout << "Name: " << name << endl;
    cout << "Age: " << age << endl;
    cout << "Group: " << group << endl;
    cout << "Rating: " << rating << endl;
}

char* name = new char {"Ivan"};
int age = 18;
int group = 1;
int rating = 5;

print(name, age, group, rating);

```
