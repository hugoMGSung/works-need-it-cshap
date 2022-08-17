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
    int i = 0;
    int j = 0;
    for (i = 0; i < 5; i++) {
        for (j = 0; j < 5 - i; j++) {            
            printf("*");            
        }
        printf("\n");
    }
    /*int sum = 0;
    for (int i = 1; i <= 100; i++)
    {
        if ((i % 3) == 0) {
            break;
        }
        sum += i;
    }*/
    //printf("sum = %d\n", sum);
	system("pause");
	return EXIT_SUCCESS;
}