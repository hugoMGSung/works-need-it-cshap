#include <string>
#include <iostream>
using namespace std;

int main()
{
	int i = 1234;
	double d = 56.789;
	string str = "String";
	bool b = true;

	// bool형 출력 방식
	cout << b << endl;
	cout << boolalpha << b << endl;

	// 진법 접두 출력 및 대소문자
	cout << hex << i << endl;
	cout << showbase << i << endl;
	cout << uppercase << i << endl;

	cout << showbase << hex;
	cout << uppercase << 77 << endl;
	cout << nouppercase << 77 << endl;
	// + 양수 기호 표시
	cout << dec << showpos << i << endl;

	int j;
	for (j = 0; j < str.length(); j++)
	{
		str[j] = toupper(str[j]); //소문자를 대문자로 교환.
	}
	cout << str << endl;
}