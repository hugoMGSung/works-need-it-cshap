/*
  filename - main.c
  version - 1.0
  description - �⺻ ���� �Լ�, �迭�� ������
  --------------------------------------------------------------------------------
  first created - 2020.02.04
  writer - Hugo MG Sung.
*/

#include <stdio.h>
#include <stdlib.h>

void print_ary(int* pa, int size);

// �����Լ�
int main(void) {
    int ary[] = { 10,20,30,40,50 };
    int ary2[] = { 10,20,30,40,50,60,70 };
    int size = 0;
    size = sizeof(ary) / sizeof(ary[0]);
    print_ary(ary, size);
    size = sizeof(ary2) / sizeof(ary2[0]);
    print_ary(ary2, size);
	system("pause");
	return EXIT_SUCCESS;
}
// �迭 ����Լ�
void print_ary(int* pa, int size) {
    for (int i = 0; i < size; i++) {
        printf("%5d", *(pa + i));
    }
    printf("\n");
}