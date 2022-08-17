#include <iostream>
using namespace std;

int main()
{
	double* rate;

	rate = new double;
	*rate = 3.1415;
	cout << *rate << endl;
	// delete rate;
}