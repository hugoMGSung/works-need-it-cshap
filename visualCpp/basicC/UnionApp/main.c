/*
  filename - main.c
  version - 1.0
  description - �⺻ ���� �Լ�, ����ü �н�
  --------------------------------------------------------------------------------
  first created - 2020.02.10.
  writer - Hugo MG Sung.
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

union student {
    int num;
    double grade;
};

enum season {
    SPRING = 5,
    SUMMER,
    FALL = 10,
    WINTER
};

int main(void) {
    /*union student s1 = { 315 };
    printf("�й� %d\n", s1.num);
    s1.grade = 4.4;
    printf("���� %.1lf\n", s1.grade);
    printf("�й� %d\n", s1.num);*/
    enum season ss;
    char* pc = NULL;
    ss = SPRING;

    switch (ss) {
    case SPRING:
        pc = "inline";
        break;
    case SUMMER:
        pc = "swimming";
        break;
    case FALL:
        pc = "trip";
        break;
    case WINTER:
        pc = "skiing";
        break;
    default:
        pc = "error";
        break;
    }
    printf("���� ����Ȱ�� %s\n", pc);

	system("pause");
	return EXIT_SUCCESS;
}