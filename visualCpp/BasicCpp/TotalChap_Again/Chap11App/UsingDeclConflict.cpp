#include <stdio.h>

namespace UTIL {
	int value;
	double score;
	void sub() { puts("sub routine"); }
}

int value;
int main()
{
	using UTIL::value;
	//int value = 5;			// 에러

	value = 1;				// UTIL의 value
	::value = 2;			// 전역 변수 value

	printf("%d\n", value);
	printf("%d\n", ::value);
	printf("%d\n", value);
}