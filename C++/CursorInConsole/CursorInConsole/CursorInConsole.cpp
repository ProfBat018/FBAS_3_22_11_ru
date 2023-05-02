#include <iostream>
#include <windows.h>

using namespace std;


void getClick(int& x, int& y)
{
	// Взять доступ к консоли
	// GetStdHandle - получить дескриптор консоли
	// дескриптор консоли - это просто число, которое идентифицирует консоль

	HANDLE hConsoleIn = GetStdHandle(STD_INPUT_HANDLE); 
	INPUT_RECORD inputRec; // Структура для хранения событий
	DWORD events; // Количество событий
	COORD coord; // Координаты клика
	bool clicked = false; // переменная, которая будет отвечать за то, был ли клик


	// Включить режим чтения мыши
	DWORD fdwMode = ENABLE_EXTENDED_FLAGS | ENABLE_WINDOW_INPUT | ENABLE_MOUSE_INPUT;
	SetConsoleMode(hConsoleIn, fdwMode); // Установить режим

	while (!clicked) {
		ReadConsoleInput(hConsoleIn, &inputRec, 1, &events); // считываем события

		if (inputRec.EventType == MOUSE_EVENT) { // Если событие - клик мыши
			if (inputRec.Event.MouseEvent.dwButtonState == FROM_LEFT_1ST_BUTTON_PRESSED) // Если нажата левая кнопка мыши
			{
				coord = inputRec.Event.MouseEvent.dwMousePosition; // Получить координаты клика
				printf("Clicked at (%d, %d)\n", coord.X, coord.Y); // Вывести координаты
				x = coord.X; // Записать координаты в переменные
				y = coord.Y; // Записать координаты в переменные
				clicked = true; // Переключить переменную
			}
		}
		if (GetAsyncKeyState(VK_ESCAPE)) {
			cout << "Exiting" << endl;
			break;
		}
		/*else if (inputRec.EventType == KEY_EVENT) {
			cout << inputRec.Event.KeyEvent.wVirtualKeyCode << endl;
		}*/
	}
}


enum Menus
{
	NEW_GAME,
	LOAD_GAME,
	EXIT
};


void openMenu(const char* parameters)
{
	int count = 0;
	size_t i = 0;
	char* parameter = new char[10] {};

	cout << "Length: " << strlen(parameters) << endl;

	for (size_t j = 0; parameters[i] != '\0'; i++)
	{
		if (parameters[i] != ' ')
		{
			parameter[j] = parameters[i];
			j++;
		}
		if ((parameters[i] == ' ') || i == strlen(parameters) - 1)
		{
			cout << ++count << '.' << ' ' << parameter << endl;
			delete[] parameter;
			j = 0;
			parameter = new char[10] {};
		}
	}
}

void showMenu()
{
	Menus menu;
	int x, y;
	
	cout << "1. New game" << endl;
	cout << "2. Load game" << endl;
	cout << "3. Exit" << endl;


	getClick(x, y);

	menu = (Menus)(y);

	switch (menu)
	{
	case NEW_GAME:
		
		system("cls");
		cout << "New game" << endl;
		Sleep(2000);
		system("cls");
		
		openMenu("Create Edit Delete");

		break;
	case LOAD_GAME:
		break;
	case EXIT:
		break;
	}
}


int main()
{
	int x, y;

	showMenu();

	getClick(x, y);
	
	cout << "Coordinates: " << x << '\t' << y << endl;


	return 0;
}
