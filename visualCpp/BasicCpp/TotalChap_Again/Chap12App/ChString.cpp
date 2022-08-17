#include <iostream>
using namespace std;

int main()
{
	char ch;
	char str[128];

	cin.get(ch);
	cout << ch << endl;
	cin.get(ch);

	cin.getline(str, 128);
	cout << str << endl;
}