#include <iostream>
#include <time.h>

using namespace std;

int main()
{
	//cout << time(0); // Unix time stamp

	int number = 0;
	
	srand(time(0)); // seed rand

	number = rand();

	//cout << 1 + rand() % 10;
	
	//cout << number << endl << number % 12 + 1;

	//cout << ((rand() % 10) - number) % 10;
}
