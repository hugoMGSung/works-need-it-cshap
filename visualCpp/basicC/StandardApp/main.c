/*
  filename - main.c
  version - 1.0
  description - �⺻ ���� �Լ�, ��ó�� �н�
  --------------------------------------------------------------------------------
  first created - 2020.02.10.
  writer - Hugo MG Sung.
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "student.h"

int main(void) {
    /*Student s1 = { 315, "ȫ�浿" };
    printf("%d, %s\n", s1.num, s1.name);*/

    /*double radius, area;

    printf("������ �Է�(100����) : ");
    scanf("%lf", &radius);
    if (radius > LIMIT) { ERR_PRN; }
    else {
        area = PI * radius * radius;

        printf("���� ���� : %.2lf (%s)\n", area, MSG);
    }*/
    /*int a = 10, b = 20;
    double x = 11.2, y = 20.3;
    int res;

    printf("a + b = %d\n", SUM(a, b));
    printf("x + y = %lf\n", SUM(x, b));

    res = 30 / MUL(2, 5);
    printf("30 / (2 * 5) = %d\n", res);*/

    /*int a1, a2;
    NAME_CAT(a, 1) = 10;
    NAME_CAT(a, 2) = 20;
    PRINT_EXP(a1 + a2);
    PRINT_EXP(a2 - a1);*/

    int max;

#if VER >= 6 
    printf("������ %d �Դϴ�\n", VER);
#endif

#if BIT == 16
    max = 32767;
#else
    max = 2147483647;
#endif

    

    printf("int�� �ִ밪 %d\n", max);
	system("pause");
	return EXIT_SUCCESS;
}

void my_print(void) {
    printf("�ӽ� ��� �Լ�\n");
    // ... ���� �߰�
}