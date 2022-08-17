#include <stdio.h>

int main()
{
	const char* str = "korea";
	int* pi;
	double d = 123.456;
	int i;

	i = static_cast<int>(d);				// 가능
	pi = static_cast<int*>(str);			// 에러
	pi = (int*)str;						// 가능
}