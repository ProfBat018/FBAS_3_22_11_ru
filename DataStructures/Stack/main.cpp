#include <iostream>
#include <string>
#include <cstdint>
#include <stack>

using namespace std;

template <typename T>
class MyStack
{
public:
    MyStack() = default;

    MyStack(uint16_t capacity, bool isExpandable = false)
    {
        this->capacity = capacity;
        this->arr = new T[capacity]{};
        this->isExpandable = isExpandable;
    }

    MyStack(initializer_list<T> list) 
    {
            this->capacity = list.size();
            this->arr = new T[this->capacity]{};

        for(const T* it = list.begin(); it != list.end(); it++) {
            this->push(*it);
        }
            
    }

    ~MyStack()
    {
        delete[] arr;
    }

    MyStack(const MyStack &other) = delete;            // запрещаем конструктор копирования
    MyStack &operator=(const MyStack &other) = delete; // запрещаем оператор присваивания

    void push(T value)
    {
        if (this->size == this->capacity && !this->isExpandable)
        {
            cout << "Stack overflow" << endl;
            return;
        }
        else if (this->size == this->capacity && this->isExpandable)
        {
            this->capacity += this->capacity / 2;

            T *newArr = new T[this->capacity]{};

            for (uint16_t i = 0; i < this->capacity; i++)
                newArr[i] = this->arr[i];

            delete[] this->arr;

            this->arr = newArr;
        }
        this->arr[this->size] = value;
        this->size++;
    }

    T pop()
    {
        if (this->size == 0)
        {
            cout << "Stack is empty" << endl;
        }
        else
        {
            T objForReturn = this->arr[this->size - 1]; 
            
            this->arr[this->size - 1] = {}; // обнуляем значение в ячейке
            this->size--;

            return objForReturn;
        }
    }

    T peek(bool reset = false)
    {
        static uint16_t index = this->size; 

        if (reset)
            index = this->size;

        if (index == 0)
        {
            index = this->size;
        }
        index--;
        return this->arr[index];
    }

private:
    T *arr{};
    uint16_t size{};
    uint16_t capacity{};
    bool isExpandable{};
};

int main()
{
    // MyStack<int> stack(5, true);

    // stack.push(1);
    // stack.push(2);
    // stack.push(3);
    // stack.push(4);
    // stack.push(5);

    // cout << stack.pop() << endl;
    // cout << stack.pop() << endl;
    // cout << stack.pop() << endl;
    // cout << stack.pop() << endl;
    // cout << stack.pop() << endl;
    // cout << stack.pop() << endl;
    // cout << stack.pop() << endl;
    // cout << stack.pop() << endl;

    // cout << stack.peek() << endl;
    // cout << stack.peek() << endl;
    // stack.push(6);
    // cout << stack.peek(true) << endl;


    MyStack<int> stack = {1, 2, 3, 4, 5};

    cout << stack.pop() << endl;
    cout << stack.pop() << endl;
    cout << stack.pop() << endl;
    cout << stack.pop() << endl;
    cout << stack.pop() << endl;


    return 0;
}
