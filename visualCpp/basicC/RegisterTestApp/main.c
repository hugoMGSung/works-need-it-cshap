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
#include <time.h>

// 메인함수
int main(void) 
{
    int tmp1 = 0;
    int tmp2 = 0;
    clock_t clk1 = clock();
    for (int i = 0; i < 100000; i++) {
        for (int j = 0; j < 70000; j++) {
            tmp1 += i;
        }
    }
    printf("1: %u ms \n", clock() - clk1);

    clock_t clk2 = clock();
    for (register int i = 0; i < 100000; i++) {
        for (register int j = 0; j < 70000; j++) {
            tmp2 += i;
        }
    }
    printf("2: %u ms \n", clock() - clk2);

	system("pause");
	return EXIT_SUCCESS;
}