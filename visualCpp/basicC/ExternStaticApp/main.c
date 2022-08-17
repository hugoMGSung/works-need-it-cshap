/*
  filename - main.c
  version - 1.0
  description - �⺻ ���� �Լ�, extern, static �н�
  --------------------------------------------------------------------------------
  first created - 2020.02.11.
  writer - Hugo MG Sung.
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int input_data(void);
double average(void);
void print_data(double avg);

int count = 0;
static int total = 0;

int main(void) {
    double avg;

    total = input_data();
    avg = average();
    print_data(avg);

	system("pause");
	return EXIT_SUCCESS;
}

void print_data(double avg) {
    printf("�Է��� ����� ���� : %d\n", count);
    printf("��ü �հ� ��� : %d, %.1lf\n", total, avg);
}