#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif // _MSC_VER

#include <stdio.h>
#include <stdlib.h> // �ý��� �������

/*
	���� �Լ�
*/
int main() {
	//printf("%d\n", 100);
	//printf("%lf\n", 3.141592);
	//printf("%.1lf\n", 3.141592); // �Ҽ��� ù��°�ڸ������� ���
	//printf("%.10lf\n", 3.141592);
	//printf("%.1lf + %.1lf = %.1lf\n", 10.2, 3.4, 10.2 + 3.4);

	/*printf("%lf\n", 1e10);
	printf("%.8lf\n", 3.14e-5);
	printf("%le\n", 0.0000314);
	printf("%.2le\n", 0.0000314);*/

	printf("%c\n", 'A');
	printf("%s\n", "ABC");
	printf("%c is sub of %s\n", 'a', "abc");
	printf("%d\n", 'F');

	system("pause");
	return 0;
}