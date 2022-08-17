#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif // _MSC_VER

#include <stdio.h>
#include <stdlib.h>

int main() {
	/*int a = 20, b = 3;
	double res;
	short sh;
	int in = 2147483647;

	res = (double) (a / b);
	printf("res = %.1lf\n", res);

	a = (int) res;
	printf("(int) %.1lf 결과 = %d\n", res, a);

	sh = (short) in;
	printf("%d, %d\n", sh, in);*/

	int a = 10;
	double b = 3.14;
	// long double ld = 0.12345678901234567890123456789012345678901234567890L;

	printf("int형 변수의 크기 : %d\n", sizeof(a));
	printf("double형 변수의 크기 : %d\n", sizeof(b));
	printf("정수형 상수의 크기 : %d\n", sizeof(10));
	printf("수식 결과 크기 : %d\n", sizeof(3.14 + 1.56));
	printf("char 자료형의 크기 : %d\n", sizeof(char));
	printf("long double 자료형의 크기 : %d\n", sizeof(long double));
	//printf("ld 값 : %Lf\n", ld);

	system("pause");
	return 0;
}