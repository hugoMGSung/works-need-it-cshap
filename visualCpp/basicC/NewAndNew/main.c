#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif // _MSC_VER

#include <stdio.h>

int main() {
	printf("Hello World!");

	int b = 0;
	scanf("%d", &b);

	printf("Value of b = %d", b);

	return 0;
}