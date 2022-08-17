#include <iostream>
using namespace std;

int main() {
	int i = 1234;
	int j = -567;
	double d = 1.234;

	/*cout << i << endl;
	cout << "8진수 : " << oct << i << endl;
	cout << "16진수 : " << hex << i << endl;
	cout << "10진수 : " << dec << i << endl;*/
	cout << i << endl;
	cout.width(10);
	cout << i << endl;
	cout.width(5);
	cout << i << endl;

	cout << d << endl;
	cout.precision(3);
	cout << showpoint << d << endl;
	cout.precision(10);
	cout << showpoint << d << endl;
	
	d = 123.4;

	cout << fixed << d << endl;
	cout << scientific << d << endl;

	bool b = true;

	cout << b << endl;
	cout << boolalpha << b << endl;

	return 0;
}