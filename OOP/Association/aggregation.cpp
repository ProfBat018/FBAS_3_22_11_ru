
#include <iostream>
#include <string>

using namespace std;

#pragma region Aggregation

/*
class Engine
{
    string model;
    float volume{};

public:
    Engine() = default;
    Engine(string model, float volume)
    {
        this->model = model;
        this->volume = volume;
    }

    friend ostream &operator<<(ostream &out, const Engine &engine)
    {
        out << "Engine model: " << engine.model << endl;
        out << "Engine volume: " << engine.volume << endl;
        return out;
    }
};

class Car
{
public:
    string make;
    string model;
    Engine engine; // aggregation

    friend ostream &operator<<(ostream &out, const Car &car)
    {
        out << "Car make: " << car.make << endl;
        out << "Car model: " << car.model << endl;
        out << "Car engine: " << car.engine << endl;
        return out;
    }
};

int main()
{

    Engine engine("V8", 5.5);

    Car car;
    car.make = "Mercedes";
    car.model = "S500";


    return 0;
}
*/
#pragma endregion

#pragma region Composition

class Engine
{
    string model;
    float volume{};

public:
    Engine() = default;
    Engine(string model, float volume)
    {
        this->model = model;
        this->volume = volume;
    }

    friend ostream &operator<<(ostream &out, const Engine &engine)
    {
        out << "\tEngine model: " << engine.model << endl;
        out << "\tEngine volume: " << engine.volume << endl;
        return out;
    }
};

class Car
{
    string make;
    string model;
    Engine *engine; // aggregation
public:
    Car(const string &make, const string &model, Engine *engine)
    {
        this->make = make;
        this->model = model;
        this->engine = engine;
    }

    ~Car()
    {
        delete this->engine;
    }

    friend ostream &operator<<(ostream &out, const Car &car)
    {
        out << "Car make: " << car.make << endl;
        out << "Car model: " << car.model << endl;
        out << "Car engine:\n"
            << *(car.engine) << endl;
        return out;
    }
};

int main()
{

    Engine *engine = new Engine("V8", 5.5);

    if (true)
    {
        Car car("Mercedes", "S500", engine);
        cout << car << endl;
    }

    cout << engine << endl; // 

    return 0;
}
#pragma endregion
