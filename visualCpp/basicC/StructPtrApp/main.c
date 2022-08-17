/*
  filename - main.c
  version - 1.0
  description - 기본 메인 함수, 구조체 포인터 학습
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
        {"홍길동", 25, "010-1234-5678", "서울시 방배동" },
        {"이수진", 27, "010-1234-5679", "서울시 성수동" },
        {"장보고", 98, "010-1234-5668", "서울시 몰라동" },
        {"유관순", 109, "011-1234-5678", "부산시 모라동" },
        {"안중근", 45, "010-5678-5678", "부산시 우동" },
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