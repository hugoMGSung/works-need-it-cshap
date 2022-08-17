#include <boost/algorithm/string.hpp>
#include <string>
#include <iostream>
using namespace std;

int main() {
	std::string str = "Hello World";
	boost::to_upper(str);
	std::string newstr = boost::to_upper_copy<std::string>("Hello World");

	cout << newstr << endl;

	return 0;
}
