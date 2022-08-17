#include <iostream>
using namespace std;

int main()
{
	int i;

	cin >> i;
	if (cin.good()) {
		cout << i << endl;
	}
	else {
		cout << "½ÇÆÐ" << endl;
	}
}