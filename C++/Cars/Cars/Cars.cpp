#include <iostream>
#include "httplib.h"

using namespace std;
using namespace httplib;


void myCopy(const char* from, int fromLength, char*& to)
{
	to = new char[fromLength] {};

	for (int i = 0; i < fromLength; i++)
	{
		to[i] = from[i];
	}
}

uint16_t getLength(const char* text)
{
	int i = 0;

	while (text[i] != '\0')
	{
		i++;
	}
	return i;
}


bool findText(char* text, const char* textTofind)
{
	int textToFindLength = getLength(textTofind);

	for (size_t i = 0; text[i] != '\0'; i++)
	{
		int counter = 0;
		for (size_t j = 0; textTofind[j] != '\0'; j++)
		{
			if (text[i] == textTofind[j])
			{
				++counter;
				i++;
			}
			else
			{
				break;
			}
			if (counter == textToFindLength)
			{
				return true;
			}

		}
	}
	return false;
}


int main() {

	Client cli("http://api.openweathermap.org");

	Result res = cli.Get("/data/2.5/weather?q=Baku&appid=5191fee1957155f779bfd029a4a97e18&units=metric");

	char* result = new char[2048] {};

	// c_str возвращает указатель на первый элемент массива. То есть превращает string в char*
	myCopy(res->body.c_str(), 2048, result);

	cout << result << endl;

	bool isFound = findText(result, "Baku");

	cout << isFound;


	return 0;
}



