#include <stdio.h>

int value;					// ���� ���� �����̽� �Ҽ�
namespace A {
	int value;				// A �Ҽ�
}

int main()
{
	int value;				// main �Ҽ�

	value = 1;				// ���� ���� value
	::value = 2;			// ���� ���� �����̽��� value
	A::value = 3;			// A ���� �����̽��� value
}