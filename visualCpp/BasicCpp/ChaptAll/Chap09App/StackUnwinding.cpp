#include <stdio.h>

class C
{	
public:
	int a;
	C() { puts("������ ȣ��"); }
	~C() { puts("�ı��� ȣ��"); }
};

void divide(int a, int d)
{
	if (d == 0) throw "0���δ� ���� �� �����ϴ�.";
	printf("������ ��� = %d�Դϴ�.\n", a / d);
}

void calc(int t, const char* m)
{
	C c;
	divide(10, t);
	c.a = 10;
}

int main()
{
	try {
		calc(1, "���");
	}
	catch (const char* message) {
		puts(message);
	}

	try
	{
		calc(0, "���2");
	}
	catch (const char* message)
	{
		printf("");
	}

	puts("���α׷��� ����˴ϴ�.");
}