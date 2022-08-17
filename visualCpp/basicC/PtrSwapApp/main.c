/*
  filename - main.c
  version - 1.0
  description - 기본 메인 함수, 포인터 스왑 학습
  --------------------------------------------------------------------------------
  first created - 2020.02.06.
  writer - Hugo MG Sung.
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
void print_ary(int(*pa)[4]);

int main(void) {
    int ary[3][4] = { {1,2,3,4}, {5,6,7,8}, {9, 10,11,12} };
    print_ary(ary);
	system("pause");
	return EXIT_SUCCESS;
}

void print_ary(int(*pa)[4]) {
    printf(" \n");
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            printf("%5d", pa[i][j]);
        }
        printf("\n");
    }
}


