#include <stdio.h>

namespace UTIL {
	int value;
	double score;
	void sub() { puts("sub routine"); }
}

int value;
int main()
{
	using namespace UTIL;
	int value = 5;			// 지역 변수 선언

	value = 1;				// 지역 변수 value
	::value = 2;			// 전역 변수 value
	UTIL::value = 3;		// UTIL의 value

	score = 1.2345;

	printf("%d\n", value);
	printf("%d\n", ::value);
}