#include <iostream>
#include <string>
#include <memory>

using namespace std;

#pragma region SmartPointers

/*
template <typename T>
class SmartPointers {
private:
    T *ptr;
public:
    SmartPointers() = default;
    explicit SmartPointers(T *p) : ptr(p) {}
    ~SmartPointers() {
        cout << "Destructor called" << endl;
        delete ptr;
    }

    T& operator*() { return *ptr; }
    T* operator->() { return ptr; }

    friend ostream& operator << (ostream &os, const SmartPointers<T> &sp) {
        os << sp.ptr;
        return os;
    }

    friend istream& operator >> (istream &is, const SmartPointers<T> &sp) {
        is >> *sp.ptr;
        return is;
    }
};

int main() {

    int* ptr = new int(10);
    SmartPointers<int> sp(ptr);

    cout << ptr << '\t' << sp << endl;
    cout << *ptr << '\t' << *sp << endl;


    return 0;
}
*/

#pragma endregion

#pragma region UniquePointer
/*
int main() {

    unique_ptr<int> ptr(new int(10));
    unique_ptr<int> ptr3 = move(ptr);

    cout << ptr3.get() << '\t' << *ptr3 << endl;
    cout << ptr.get() << '\t' << *ptr << endl;

//    cout << ptr.get() << '\t' << *ptr << endl;
//
//    int* ptr2 = ptr.release();
//
//    cout << ptr2 << '\t' << *ptr2 << endl;
//    cout << ptr.get() << '\t' << *ptr << endl;



    return 0;
}
*/
#pragma endregion

#pragma region SharedPointer

/*
int main() {
    shared_ptr<int> ptr(new int(10));
    shared_ptr<int> ptr2 = ptr;

//    cout << ptr.get() << '\t' << *ptr << endl;
//    cout << ptr2.get() << '\t' << *ptr2 << endl;
//
//    cout << ptr.use_count() << endl;

    shared_ptr<int> ptr3 = move(ptr2);

    cout << ptr.get() << '\t' << *ptr << endl;
    cout << ptr3.get() << '\t' << *ptr3 << endl;
    cout << ptr2.get() << '\t' << *ptr2 << endl;

    return 0;
}
*/
#pragma endregion

#pragma region WeakPointer
/*
int main() {

shared_ptr<int> global_ptr(new int(10));

weak_ptr<int> weak_ptr1 = global_ptr;
weak_ptr<int> weak_ptr2 = global_ptr;

cout << global_ptr.use_count() << endl;

global_ptr.reset();

}
*/
#pragma endregion


