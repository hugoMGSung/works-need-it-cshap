/*
  filename - main.c
  version - 1.0
  description - �⺻ ���� �Լ�
  --------------------------------------------------------------------------------
  first created - 2020.02.01
  writer - Hugo MG Sung.
*/

#include <stdio.h>
#include <stdlib.h>

// �����Լ�
int main(void) 
{
    int count = 0;
    while (1) {
        printf("Be happy!\n");
        count++;
        if (count == 10) { break; }
    }
	system("pause");
	return EXIT_SUCCESS;
}