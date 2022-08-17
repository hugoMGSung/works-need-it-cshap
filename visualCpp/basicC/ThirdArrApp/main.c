/*
  filename - main.c
  version - 1.0
  description - 기본 메인 함수, 3차원 배열 학습
  --------------------------------------------------------------------------------
  first created - 2020.02.05.
  writer - Hugo MG Sung.
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// 메인함수
int main(void) {
    int score[2][3][4] = {
        { {1,2,3,4} , {5,6,7,8}, {9, 10, 11,12} },
        { {13,14,15,16} , {17,18,19,20}, {21, 22, 23,24} }
    };
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            for (int k = 0; k < 4; k++)
            {
                printf("score[%d][%d][%d] = %d\n", i, j, k, score[i][j][k]);
            }
            printf("\n");
        }
    }

	system("pause");
	return EXIT_SUCCESS;
}