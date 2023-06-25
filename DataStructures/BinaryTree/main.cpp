#include <iostream>

using namespace std;

template<typename T>
class BinaryTree {
public:
    struct Node {
        T data;
        Node *left{};
        Node *right{};

        Node(T data) : data(data) {}
    };

    BinaryTree() = default;

    BinaryTree(T data) {
        this->root = new Node(data);
    }

    BinaryTree(initializer_list<T> list) {
        for (const T* li = list.begin(); li < list.end(); ++li) {
            bool res = this->tryAdd(*li);
            if (res) {
                cout << "Added " << *li << endl;
            } else {
                cout << "Failed to add " << *li << endl;
            }
        }
    }

    bool tryAdd(T data) {
        if (this->root == nullptr) {
            this->root = new Node(data);
            return true;
        } else {
            Node *current = this->root;
            while (true) {
                if (data < current->data) {
                    if (current->left == nullptr) {
                        current->left = new Node(data);
                        return true;
                    } else {
                        current = current->left;
                    }
                } else if (data > current->data) {
                    if (current->right == nullptr) {
                        current->right = new Node(data);
                        return true;
                    } else {
                        current = current->right;
                    }
                } else {
                    return false;
                }
            }
        }
    }

private:
    Node *root{};
};


int main() {

    BinaryTree<int> tree {19, 3, 10, 20, 22, 13, 9};

    return 0;
}
