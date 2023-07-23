# Тема урока: "Работа с файлами"

Мы с вами привыкли использовать `C` методы для 
работы с файлами. Например:

```c++
#include <stdio.h>

using namespace std;

int main() {
    
    FILE** file{};
    fopen_s(file, "file.txt", "w"); // метод из C 
    
    if (file != nullptr) 
    {
        fprintf(*file, "Hello world!"); // метод из C
    }
}
```

Давайте посмотрим как это делается в современном `C++`:

```c++


std::ifstream file("data.txt", std::ios::in);
std::string text;

if (file.is_open()) {
    std::stringstream ss;
    std::string line;
    while (getline(file, line)) {
        ss << line << "\n";
    }
    text = ss.str();
}

std::cout << text << std::endl;
```

### Stringstream - поток для строк
Под капотом `stringstream` не перезаписывает строку при каждой операции, а использует буфер.
Этот буфер может состоять из нескольких блоков, которые могут быть выделены в куче.


### Разница между ifstream и ofstream и fstream

* `ifstream` - поток для чтения из файла
* `ofstream` - поток для записи в файл
* `fstream` - поток для чтения и записи в файл
