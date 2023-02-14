#include <iostream>

using namespace std;


int main()
{
	/*
	Привыйчные нам условные выражения
		if - если
		else - иначе
		else if - иначе если
	Тернарные выражения
		int number = 0;

		cout << ((number % 2 == 0) ? "Even" : "Odd" ) << endl;

	switch - Его не особо можно считать за условие,
			 так как он отслежиавет состояние переменной.
	*/


	// Правила написания условий...

	//if (false)
	//{
	//	cout << "A" << endl;
	//}
	//cout << "B" << endl;
	//else if (true)
	//{
	//	cout << "C" << endl;
	//}



	// Можно не писать фигурные скобки, если внутри выражения одна строка

	//int num = 2;
	//
	//if (num % 2 == 0)
	//	cout << "Yes";
	//else
	//	cout << "No";


	//int num = 2;

	//if (num % 2 != 0)
	//	cout << "Odd";
	//else if (true)
	//{
	//	cout << "Even";
	//}



	// int num {}; унифицированная инициализация  

	int num1 = 0, num2 = 0, choice = 0;
	char symbol{};
	
	float res{};

	cout << "Enter num1 & num2" << endl;
	cin >> num1 >> num2;

	cout
		<< "Enter your choice:" << endl
		<< "1. Add" << endl
		<< "2. Subtract" << endl
		<< "3. Multiply" << endl
		<< "4. Divide" << endl;
	cin >> choice;

	const int n = 1;

	switch (choice)
	{
	case n:
		symbol = '+';
		res = num1 + num2;
		break;
	case 2:
		symbol = '-';
		res = num1 - num2;
		break;
	case 3:
		symbol = '*';
		res = num1 * num2;
		break;
	case 4:
		symbol = '/';
		res = num1 / num2;
		break;
	default:
		cout << "Wrong input...";
		num1 = 0;
		num2 = 0;
		symbol = '+';
		break;
	}

	cout
		<< "Result is:" << endl
		<< num1 << ' ' << symbol << ' ' << num2 << " = " << res << endl;


	return 0;
}
