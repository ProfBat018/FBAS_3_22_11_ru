#include <iostream>
#include <vector>

using namespace std;

template<typename T>
class MyVector {
private:
    T *arr{};
    size_t size{}; // size_t. unsigned long long int
    size_t capacity{};
public:
    MyVector(size_t size) {
        this->capacity = size * 2;
        this->arr = new T[capacity]{};
    }

    MyVector(initializer_list<int> list) {
        this->size = list.size();
        this->capacity = list.size() * 2;
        this->arr = new T[capacity]{};

//        int j = 0;
//        for (auto i : list) {
//            this->arr[j] = i;
//            j++;
//        }

        for (const T* i = list.begin(); i < list.end(); i++) {
            this->arr[i - list.begin()] = *i;
        }
    }

    friend ostream &operator<<(ostream &out, const MyVector &v) {
        for (size_t i = 0; i < v.size; i++) {
            out << v.arr[i] << ' ';
        }
        return out;
    }


    T& operator[](size_t index) {
        return this->arr[index];
    }

    void append(T value) {
        if (this->size == this->capacity) {
            this->capacity *= 2;

            T *new_arr = new T[this->capacity]{};

            for (size_t i = 0; i < this->size; i++) {
                new_arr[i] = this->arr[i];
            }
            delete[] this->arr;
            this->arr = new_arr;
        }
        this->arr[this->size] = value;
        this->size++;
    }



    ~MyVector() {
        delete[] arr;
    }
};


int main() {
    /*
    MyVector<int> v(5);
    MyVector<int> v1{5}; // то же самое, что и MyVector<int> v1(5);

    MyVector<int> v2({1, 2, 3, 4, 5}); // initializer_list
    MyVector<int> v3{1, 2, 3, 4, 5}; // то же самое, что и MyVector<int> v3({1, 2, 3, 4, 5});
*/

    MyVector<int> v4{1, 2, 3, 4, 5};

    cout << v4[3] << endl;

    return 0;
}
