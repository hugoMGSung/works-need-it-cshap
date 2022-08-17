/*
  filename - main.c
  version - 1.0
  description - 기본 메인 함수, 동적 메모리할당
  --------------------------------------------------------------------------------
  first created - 2020.02.07.
  writer - Hugo MG Sung.
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
 
int main(void) {
    int* pi;
    int size = 5;
    int count = 0;
    int num = 0;

    pi = (int*)malloc(size * sizeof(int)); 
    if (pi == NULL) {
        printf("# 메모리가 부족합니다.\n");
        exit(EXIT_FAILURE);
    }
    while (1) {
        printf("양수만 입력 => ");
        scanf("%d", &num);
        if (num <= 0) { break; }
        if (count == size) {
            pi = (int*)realloc(pi, size * sizeof(int));
        }
        pi[count++] = num;
    }
    for (int i = 0; i < count; i++)
    {
        printf("%5d", pi[i]);
    }
    printf("\n");
    free(pi);
	system("pause");
	return EXIT_SUCCESS;
}