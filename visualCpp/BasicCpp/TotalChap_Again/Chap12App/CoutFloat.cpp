#include <iostream>
using namespace std;

int main()
{
	double d = 1.234;

	// �Ǽ��� ���е� ����
	cout << d << endl;
	cout.precision(3);
	cout << d << endl;
	cout.precision(10);
	cout << showpoint << d << endl;
	cout.precision(6);

	// �Ǽ� ��� ���
	cout << fixed << d << endl;
	cout << scientific << d << endl;
}