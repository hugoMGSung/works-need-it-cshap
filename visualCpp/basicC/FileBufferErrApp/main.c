/*
  filename - main.c
  version - 1.0
  description - 기본 메인 함수, 
  --------------------------------------------------------------------------------
  first created - 2020.02.01
  writer - Hugo MG Sung.
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(void) {
    FILE* fp;
    int age;
    char name[20];
    fp = fopen("a.txt", "r");
    if (fp == NULL) { return EXIT_FAILURE; }

    fscanf(fp, "%d", &age);
    fgetc(fp);
    fgets(name, sizeof(name), fp);
    
    printf("이름 : %s, 나이 : %d\n", name, age);

    fclose(fp);
	system("pause");
	return EXIT_SUCCESS;
}