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
	int value = 5;			// ���� ���� ����

	value = 1;				// ���� ���� value
	::value = 2;			// ���� ���� value
	UTIL::value = 3;		// UTIL�� value

	score = 1.2345;

	printf("%d\n", value);
	printf("%d\n", ::value);
}