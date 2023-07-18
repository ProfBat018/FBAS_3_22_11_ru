#include <iostream>
#include <string>
#include <regex>

using namespace std;

class Person {
public:
    Person(string& name, string& surname, string& email, string& phone) {

        // backslash is used to escape special characters
        // \w+ means one or more word characters
        // \. means a dot
        // | means or
        // _ means an underscore
        // ? means zero or one
        // * means zero or more
        // \w* means zero or more word characters
        // @ means an at sign
        // \w+ means one or more word characters
        // \. means a dot
        // \w+ means one or more word characters

        //// elvin.azim01@gmail.com
        //regex email_regex(R"((\w+)(\.|_)?(\w*)@(\w+)(\.(\w+))+)");
        regex email_regex (R"(([a-zA-Z0-9]+)(\.|_)?([a-zA-Z0-9]*)@([a-zA-Z0-9]+)(\.([a-zA-Z]{2,}))+)");
        regex phone_regex("^[+]994[0-9]{9}");

        this->name = name;
        this->surname = surname;

        if (!regex_match(email, email_regex))
            throw invalid_argument("Invalid email");
        if (!regex_match(phone, phone_regex))
            throw invalid_argument("Invalid phone");

        this->email = email;
        this->phone = phone;
    }

    friend ostream& operator<<(ostream& os, const Person& p) {
        os << "Name: " << p.name << endl;
        os << "Surname: " << p.surname << endl;
        os << "Email: " << p.email << endl;
        os << "Phone: " << p.phone << endl;
        return os;
    }
private:
    string name;
    string surname;
    string email;
    string phone;
};


int main() {

    string name = "Baxtiyar";
    string surname = "Mirzoyev";
    string email = "baxakrutoy@sportsmen.goda.net";
    string phone = "+994503437976";

    Person* p1{};

    try {
        p1 = new Person(name, surname, email, phone);
        cout << *p1 << endl;
    } catch (exception& ex) {
        cout << ex.what() << endl;
    }
    return 0;
}
