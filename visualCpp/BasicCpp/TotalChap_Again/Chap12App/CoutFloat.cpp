#include <iostream>
using namespace std;

int main()
{
	double d = 1.234;

	// 실수의 정밀도 지정
	cout << d << endl;
	cout.precision(3);
	cout << d << endl;
	cout.precision(10);
	cout << showpoint << d << endl;
	cout.precision(6);

	// 실수 출력 방식
	cout << fixed << d << endl;
	cout << scientific << d << endl;
}