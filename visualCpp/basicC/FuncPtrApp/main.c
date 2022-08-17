/*
  filename - main.c
  version - 1.0
  description - 기본 메인 함수, 함수포인터 학습
  --------------------------------------------------------------------------------
  first created - 2020.02.05.
  writer - Hugo MG Sung.
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
int main(void) {
    int a = 10;
    double b = 20.4;
    void* vp;

    vp = &a;
    printf("a is %d\n", *(int*)vp);
    vp = &b;
    printf("b is %.1f\n", *(double*)vp);
    
	system("pause");
	return EXIT_SUCCESS;
}
