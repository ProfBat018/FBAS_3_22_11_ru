#include <regex>

namespace globals {
    std::regex email("^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\\.[a-zA-Z0-9-.]+$");
    std::regex phone("^\\+?[0-9]{3}-?[0-9]{6,12}$");
    std::regex date("^[0-9]{2}[/][0-9]{2}[/][0-9]{4}$");
}
