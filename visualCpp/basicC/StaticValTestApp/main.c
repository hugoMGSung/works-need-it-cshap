/*
  filename - main.c
  version - 1.0
  description - �⺻ ���� �Լ�, �������� �н�.
  --------------------------------------------------------------------------------
  first created - 2020.02.05.
  writer - Hugo MG Sung.
*/

#include <stdio.h>
#include <stdlib.h>

// �����Լ�
int main(void) {
    register int i;
    int sum = 0;

    for (i = 0; i <= 10000; i++)
    {
        sum += i;
    }
    printf("sum is %d\n", sum);
	system("pause");
	return EXIT_SUCCESS;
}
