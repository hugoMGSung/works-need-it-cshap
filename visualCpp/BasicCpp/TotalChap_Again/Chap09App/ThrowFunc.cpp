#include <stdio.h>

void divide(int a, int d)
{
	if (d == 0) throw "0으로는 나눌 수 없습니다.";
	printf("나누기 결과 = %d입니다.\n", a / d);
}

int main()
{
	try {
		divide(10, 0);
	}
	catch (int code) {
		printf("%d번 에러가 발생했습니다.\n", code);
	}
	catch (const char* message) {
		puts(message);
	}
	divide(10, 5);
}