#include <stdio.h>

int main()
{
	char str[] = "string";
	const char* c1 = str;
	char* c2;

	c2 = const_cast<char*>(c1);
	c2[0] = 'a';
	puts(c2);
}