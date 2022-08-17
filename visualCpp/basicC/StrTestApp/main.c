/*
  filename - main.c
  version - 1.0
  description - 기본 메인 함수, 문자열 학습
  --------------------------------------------------------------------------------
  first created - 2020.02.05.
  writer - Hugo MG Sung.
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// 메인함수
int main(void) {
    /*char *dessert = "apple";

    printf("오늘의 후식은 %s 입니다.\n", dessert);
    dessert = "banana";
    printf("내일 후식은 %s 입니다.\n", dessert);*/
    
    /*char str[80];

    printf("공백포함 문자열 입력 :");
    fgets(str, sizeof(str), stdin);
    printf("문자열은 : %s\n", str);*/

    /*int age;
    char name[20];

    printf("나이입력 :");
    scanf("%d", &age);
    getchar();
    printf("이름입력 :");
    gets(name);
    printf("나이 : %d, 이름 : %s\n", age, name);*/

    /*char str[80] = "apple juice";
    char* ps = "banana";

    puts(str);
    fputs(ps, stdout);
    puts(" jam");*/
    /*char str1[80] = "strawberry";
    char str2[80] = "apple";
    char* ps1 = "banana";
    char* ps2 = str2;
    printf("최초 %s\n", str1);
    strcpy(str1, str2);
    printf("바뀐 %s\n", str1);
    strcpy(str1, ps1);
    printf("바뀐 %s\n", str1);
    strcpy(str1, ps2);
    printf("바뀐 %s\n", str1);
    strcpy(str1, "raspberry");
    printf("바뀐 %s\n", str1);*/

    /*char str[20] = "mango tree";
    strncpy(str, "apple", 5);
    printf("변환 스트링 %s\n", str);*/

    /*char str1[80], str2[80];
    char* resp;

    printf("2개의 과일 이름 입력 :");
    scanf("%s%s", str1, str2);

    printf("과일명 %s, %s\n", str1, str2);
    if (strlen(str1) > strlen(str2)) {
        resp = str1;
    }
    else {
        resp = str2;
    }

    printf("더 긴 단어는 %s\n", resp);*/

    char str1[80] = "apple";
    char str2[80] = "banana";

    printf("사전에 나중에 나오는 과일 ");
    if (strcmp(str1, str2) > 0) {
        printf("%s\n", str1);
    }
    else {
        printf("%s\n", str2);
    }

	system("pause");
	return EXIT_SUCCESS;
}