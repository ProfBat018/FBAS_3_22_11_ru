#include <iostream>
#include <string>
#include <cstdint>
#include <stack>

using namespace std;

template <typename T>
class MyStack {
public:
    MyStack() = default;
    MyStack(uint16_t capacity) {
        this->capacity = capacity;
        this->arr = new T[capacity]{};
    }

    void push(T value) {
        if (this->size == this->capacity) {
            this->capacity *= 2;
            T* new_arr = new T[this->capacity]{};
            for (int i = 0; i < this->size; i++) {
                new_arr[i] = this->arr[i];
            }
            delete[] this->arr;
            this->arr = new_arr;
        }
        this->arr[this->size] = value;
        this->size++;
    }

    T pop() {
        if (this->size == 0) {
            throw is_empty<MyStack<T>>();
        }
        this->size--;
        return this->arr[this->size];
    }

    T peek(bool reset=false) {
        static int index = this->size - 1;

        if (index <= 0 || reset) {
            index = this->size - 1;
        }
        T value = this->arr[index];
        index--;
        return value;
    }


    ~MyStack() {
        delete[] this->arr;
    }

    MyStack(const MyStack& other) = delete;
    MyStack& operator=(const MyStack& other) = delete;

private:
    uint16_t size{}; // текущий размер стека
    uint16_t capacity{}; // максимальный размер стека
    T* arr{}; // массив для хранения элементов стека
};

int main()
{
    MyStack<int> stack(10);

    stack.push(1);
    stack.push(2);
    stack.push(3);
    stack.push(4);

    cout << stack.peek() << endl;
    cout << stack.peek() << endl;
    stack.push(5);
    stack.push(6);
    cout << stack.peek(true) << endl;






    return 0;
}