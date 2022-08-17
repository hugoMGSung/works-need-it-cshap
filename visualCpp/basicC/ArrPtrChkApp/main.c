/*
  filename - main.c
  version - 1.0
  description - 기본 메인 함수
  --------------------------------------------------------------------------------
  first created - 2020.02.01
  writer - Hugo MG Sung.
*/

#include <stdio.h>
#include <stdlib.h>

// 메인함수
int main(void) 
{
    int ary[5] = { 10, 20, 30, 40, 50 };
    int* pa = ary;
    int* pb = pa + 3;
    
    printf("pa : %u\n", pa);
    printf("pb : %u\n", pb);
    pa++;
    printf("pb - pa : %u\n", pb - pa);
    if (pa < pb) { printf("%d\n", *pa); }
    else { printf("%d\n", *pb); }

	system("pause");
	return EXIT_SUCCESS;
}