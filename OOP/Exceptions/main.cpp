#include <iostream>
#include <string>
using namespace std;

// К примеру я создаю свой вектор

class EmptyStackException : public exception {
public:
    const char* what() const throw() override {
        return "Stack is empty";
    }
};

class NullPtrException : public exception {
public:
    NullPtrException() = default;
    NullPtrException(string message, int code=0) {
        this->message = message;
        this->code = code;
    }
    const char* what() const throw() override {
        return this->message.c_str();
    }

    string message = "Object not set to an instance of an object.";
    int code = 0;
};

template <typename T>
class MyStack {
public:
    MyStack() = default;
    MyStack(uint16_t capacity) {
        this->capacity = size;
        this->arr = new T[size]{};
    }
    MyStack(initializer_list<T> list) {

    }
    void push(T value) {
        if (this->size == this->capacity) {
            cout << "Stack is full" << endl;
        }
        this->arr[this->size] = value;
        this->size++;
    }

    T pop() {
        if (this->size == 0) {
            throw EmptyStackException();
        // cout << "Stack is empty" << endl;
        // return T{}; // Например если T - int, то вернет 0
        }
        if (this->arr == nullptr) {
            throw NullPtrException("Null pointer exception", 404);
        }
        this->size--;
        return this->arr[this->size];
    }
    ~MyStack() {
        delete[] arr;
    }
private:
    T* arr{};
    uint16_t size{};
    const uint16_t capacity {1};
};


int main() {

    MyStack<int> stack;

    /*
    try {
        stack.pop();
    } catch (int error) {
        cout << "Error: " << error << endl;
    }
    */
    /*
    try {
        stack.pop();
    } catch (...) {
        cout << "Error" << endl;
    }
    */

    try {
        stack.pop();
    } catch (exception& error) {
        cout << "Error: " << error.what() << endl;
    }

    return 0;
}
