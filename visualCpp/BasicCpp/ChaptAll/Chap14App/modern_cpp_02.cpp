#include <boost/algorithm/string.hpp>
#include <string>
#include <iostream>
using namespace std;

int main() {
	string str = "Hello World";
		
	for (int i = 0; i < str.size(); i++)
	{
		str[i] = toupper(str[i]);
	}
	cout << str << endl;

	string str2 = "Hello World!!";
	boost::to_upper(str2);
	cout << str2 << endl;

	return 0;
}