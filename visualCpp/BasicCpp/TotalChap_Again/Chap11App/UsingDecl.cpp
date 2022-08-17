#include <stdio.h>

namespace UTIL {
	int value;
	double score;
	void sub() { puts("sub routine"); }
}

void mysub();

int main()
{
	using UTIL::value;

	value = 3;
	UTIL::score = 1.2345;
	UTIL::sub();

	mysub();
	printf("%d\n", UTIL::value);
}

void mysub()
{
	UTIL::value = 5;
}