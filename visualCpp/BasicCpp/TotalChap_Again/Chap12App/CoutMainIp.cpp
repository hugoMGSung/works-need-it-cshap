#include <string>
#include <iostream>
using namespace std;

int main()
{
	int i = 1234;
	double d = 56.789;
	string str = "String";
	bool b = true;

	// bool�� ��� ���
	cout << b << endl;
	cout << boolalpha << b << endl;

	// ���� ���� ��� �� ��ҹ���
	cout << hex << i << endl;
	cout << showbase << i << endl;
	cout << uppercase << i << endl;

	cout << showbase << hex;
	cout << uppercase << 77 << endl;
	cout << nouppercase << 77 << endl;
	// + ��� ��ȣ ǥ��
	cout << dec << showpos << i << endl;

	int j;
	for (j = 0; j < str.length(); j++)
	{
		str[j] = toupper(str[j]); //�ҹ��ڸ� �빮�ڷ� ��ȯ.
	}
	cout << str << endl;
}