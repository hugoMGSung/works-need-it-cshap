/*
  filename - main.c
  version - 1.0
  description - 기본 메인 함수. 분할컴파일 학습
  --------------------------------------------------------------------------------
  first created - 2020.02.11.
  writer - Hugo MG Sung.
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "sub.h"

// 메인함수
int main(void) {
    int a, b;
    double avg;

    input_data(&a, &b);
    avg = average(a, b);
    printf("%d, %d의 평균값은 %.1lf\n", a, b, avg);

	system("pause");
	return EXIT_SUCCESS;
}