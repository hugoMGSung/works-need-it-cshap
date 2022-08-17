/*
  filename - main.c
  version - 1.0
  description - 기본 메인 함수, 파일 복사 학습
  --------------------------------------------------------------------------------
  first created - 2020.02.10.
  writer - Hugo MG Sung.
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(void) {
    FILE* ifp, * ofp;
    char str[80];
    char* res;

    ifp = fopen("aa.txt", "r");
    if (ifp == NULL) {
        printf("파일 오픈 실패\n");
        return EXIT_FAILURE;
    }
    ofp = fopen("bb.txt", "w");
    if (ofp == NULL) {
        printf("파일 생성 실패\n");
        return EXIT_FAILURE;
    }

    while (1) {
        res = fgets(str, sizeof(str), ifp);
        if (res == NULL) { break; }
        str[strlen(str) - 1] = '\0';
        fputs(str, ofp);
        fputs("\n", ofp);
    }
    fclose(ifp);
    fclose(ofp);
	system("pause");
	return EXIT_SUCCESS;
}