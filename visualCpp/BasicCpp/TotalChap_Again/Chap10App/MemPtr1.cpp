#include <stdio.h>
#include <stdlib.h>

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

	while (true)
	{
		printf("���� ����� �����Ͻÿ�. 0=���ϱ�, 1=����, 2=���ϱ�, 9=���� : ");
		scanf("%d", &ch);

		switch (ch) {
		case 0:
			c.Op1(a, b);
			break;
		case 1:
			c.Op2(a, b);
			break;
		case 2:
			c.Op3(a, b);
			break;
		case 9:
			return 0;
			break;
		}
	}
	return 0;
}