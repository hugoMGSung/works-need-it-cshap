/*
  filename - main.c
  version - 1.0
  description - 기본 메인 함수, 변수 영역 데이터 공유 테스트
  --------------------------------------------------------------------------------
  first created - 2020.02.05.
  writer - Hugo MG Sung.
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int *add_ten(int a);

int main(void) { // 메인함수
    int a = 10;
    int *res = add_ten(a);
    printf("res = %d\n", *res);
	system("pause");
	return EXIT_SUCCESS;
}

int *add_ten(int a) {
    static int res;
    res = a + 10;
    return &res;
}