/*
  filename - main.c
  version - 1.0
  description - �⺻ ���� �Լ�, ���ڿ� �н�
  --------------------------------------------------------------------------------
  first created - 2020.02.05.
  writer - Hugo MG Sung.
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// �����Լ�
int main(void) {
    /*char *dessert = "apple";

    printf("������ �Ľ��� %s �Դϴ�.\n", dessert);
    dessert = "banana";
    printf("���� �Ľ��� %s �Դϴ�.\n", dessert);*/
    
    /*char str[80];

    printf("�������� ���ڿ� �Է� :");
    fgets(str, sizeof(str), stdin);
    printf("���ڿ��� : %s\n", str);*/

    /*int age;
    char name[20];

    printf("�����Է� :");
    scanf("%d", &age);
    getchar();
    printf("�̸��Է� :");
    gets(name);
    printf("���� : %d, �̸� : %s\n", age, name);*/

    /*char str[80] = "apple juice";
    char* ps = "banana";

    puts(str);
    fputs(ps, stdout);
    puts(" jam");*/
    /*char str1[80] = "strawberry";
    char str2[80] = "apple";
    char* ps1 = "banana";
    char* ps2 = str2;
    printf("���� %s\n", str1);
    strcpy(str1, str2);
    printf("�ٲ� %s\n", str1);
    strcpy(str1, ps1);
    printf("�ٲ� %s\n", str1);
    strcpy(str1, ps2);
    printf("�ٲ� %s\n", str1);
    strcpy(str1, "raspberry");
    printf("�ٲ� %s\n", str1);*/

    /*char str[20] = "mango tree";
    strncpy(str, "apple", 5);
    printf("��ȯ ��Ʈ�� %s\n", str);*/

    /*char str1[80], str2[80];
    char* resp;

    printf("2���� ���� �̸� �Է� :");
    scanf("%s%s", str1, str2);

    printf("���ϸ� %s, %s\n", str1, str2);
    if (strlen(str1) > strlen(str2)) {
        resp = str1;
    }
    else {
        resp = str2;
    }

    printf("�� �� �ܾ�� %s\n", resp);*/

    char str1[80] = "apple";
    char str2[80] = "banana";

    printf("������ ���߿� ������ ���� ");
    if (strcmp(str1, str2) > 0) {
        printf("%s\n", str1);
    }
    else {
        printf("%s\n", str2);
    }

	system("pause");
	return EXIT_SUCCESS;
}