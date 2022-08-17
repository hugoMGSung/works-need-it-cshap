#include <stdio.h>

class Calc {
public:
	void Op1(int a, int b) { printf("%d\n", a + b); }
	void Op2(int a, int b) { printf("%d\n", a - b); }
	void Op3(int a, int b) { printf("%d\n", a * b); }
	void Op4(int a, int b) { printf("%d\n", a / b); }

	void DoCalc(void (Calc::* fp)(int, int), int a, int b) {
		puts("�ʱ� ���� ���� ����");
		printf("%d�� %d�� ���� ��� : ", a, b);
		(this->*fp)(a, b);
		puts("���� ���� ����");
	}
};

int main() {
	int ch;
	Calc c;
	int a = 10, b = 5;
	void (Calc:: * arOp[4])(int, int) = { &Calc::Op1, &Calc::Op2, &Calc::Op3, &Calc::Op4 };

	while (true)
	{
		printf("������ �����ϼ���, 1=���ϱ�, 2=����, 3=���ϱ�, 4=������, 0=���� : ");
		scanf("%d", &ch);

		if (ch >= 1 && ch < 5) {			
			c.DoCalc(arOp[ch - 1], a, b);
		}
		else if (ch == 0) {
			return 0;
		}
	}	

	return 0;
}