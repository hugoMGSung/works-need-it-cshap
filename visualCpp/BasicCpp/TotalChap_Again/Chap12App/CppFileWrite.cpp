#include <iostream>
#include <fstream>
using namespace std;

int main()
{
	ofstream f;

	f.open("D:\\Temp\\cpptest.txt");
	if (f.is_open()) {
		f << "String " << 1234 << endl;
		f.close();
	}
	else {
		cout << "���� ���� ����" << endl;
	}
}