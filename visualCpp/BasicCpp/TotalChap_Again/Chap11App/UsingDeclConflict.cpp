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
	//int value = 5;			// ����

	value = 1;				// UTIL�� value
	::value = 2;			// ���� ���� value

	printf("%d\n", value);
	printf("%d\n", ::value);
	printf("%d\n", value);
}