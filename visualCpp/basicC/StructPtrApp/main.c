/*
  filename - main.c
  version - 1.0
  description - �⺻ ���� �Լ�, ����ü ������ �н�
  --------------------------------------------------------------------------------
  first created - 2020.02.01
  writer - Hugo MG Sung.
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

struct address {
    char name[20];
    int age;
    char tel[20];
    char addr[80];
};

void print_list(struct address* lp);

int main(void) {
    struct address  list[5] = {
        {"ȫ�浿", 25, "010-1234-5678", "����� ��赿" },
        {"�̼���", 27, "010-1234-5679", "����� ������" },
        {"�庸��", 98, "010-1234-5668", "����� ����" },
        {"������", 109, "011-1234-5678", "�λ�� ���" },
        {"���߱�", 45, "010-5678-5678", "�λ�� �쵿" },
    };
    print_list(list);
	system("pause");
	return EXIT_SUCCESS;
}

void print_list(struct address* lp) {
    for (int i = 0; i < 5; i++) {
        printf("%10s%5d\n",
            (*(lp + i)).name, (lp+i)->age);
    }
}