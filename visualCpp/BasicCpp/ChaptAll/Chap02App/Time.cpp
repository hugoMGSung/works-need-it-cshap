#include <stdio.h>
#include "Time.h"

Time::Time(int h, int m, int s) : hour(h), min(m), sec(s) { }

//void Time::SetTime(int h, int m, int s) {
//	hour = h;
//	min = m;
//	sec = s;
//}

void Time::OutTime() {
	printf("현재 시간은 %d:%d:%d입니다\n", hour, min, sec);
}

