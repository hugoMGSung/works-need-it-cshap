#include <stdio.h>

class Calc
{
public:
	void Op1(int a, int b) { printf("%d\n", a + b); }
	void Op2(int a, int b) { printf("%d\n", a - b); }
	void Op3(int a, int b) { printf("%d\n", a * b); }
};

int main()
{
	int ch;
	Calc c;
	int a = 3, b = 4;
	void (Calc:: * arop[3])(int, int) = { &Calc::Op1,&Calc::Op2,&Calc::Op3 };

	while (true)
	{
		printf("연산 방법을 선택하시오. 0=더하기, 1=빼기, 2=곱하기, 9=끝내기 : ");
		scanf("%d", &ch);

		if (ch >= 0 && ch <= 2) {
			(c.*arop[ch])(3, 4);
		}
		else if (ch == 9) {
			return 0;
		}
	}
	
}