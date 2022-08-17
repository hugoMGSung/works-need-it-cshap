#include <stdio.h>
#include "sub.h"

void input_data(int* pa, int* pb) {
	printf("두 정수 입력 :");
	scanf("%d%d", pa, pb);
}

double average(int a, int b) {
	int tot;
	double avg;

	tot = a + b;
	avg = tot / 2.0;

	return avg;
}