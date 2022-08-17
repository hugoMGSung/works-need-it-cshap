#include <stdio.h>
#include <string>
#include <iostream>
using namespace std;

int main() {
	char str[] = "string";
	string str2 = "string";
	const char* c1 = str;	
	char* c2;

	c2 = const_cast<char *>(c1);
	puts(c2);

	c2[0] = 'S';
	puts(c2);

	cout << "Hello world" << endl;

	return 0;
}