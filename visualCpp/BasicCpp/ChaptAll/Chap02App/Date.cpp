#include <stdio.h>
#include "Date.h"

void Date::SetDate(int y, int m, int d) {
	year = y;
	month = m;
	day = d;
}

void Date::OutDate() {
	printf("������ %d�� %d�� %d�� �Դϴ�.\n", year, month, day);
}