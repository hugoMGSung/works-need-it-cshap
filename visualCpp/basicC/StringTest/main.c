#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif // _MSC_VER

#include <stdio.h>
#include <stdlib.h>

int main() {
	
	char fruit[20] = "strawberry";

	printf("%s \n", fruit);

	int age;
	double height;

	printf("나이와 키를 입력 : ");
	scanf("%d%lf", &age, &height);
	printf("나이 %d, 키 %.1f\n", age, height);

	char grade;
	char name[20];
	getchar();

	printf("학점을 입력하세요 : ");
	scanf("%c", &grade);
	printf("이름을 입력하세요 : ");
	scanf("%s", &name);

	printf("%s 의 학점 : %c\n", name, grade);

	system("pause");
	return 0;
}