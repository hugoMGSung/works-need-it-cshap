#include <stdio.h>

class Time {
public:
	int hour, min, sec;

	void OutTime() {
		printf("%d:%d:%d ¿‘¥œ¥Ÿ\n", hour, min, sec);
	}
};

int main() {
	Time now;
	int Time::* pi;

	pi = &Time::hour;
	now.*pi = 11;
	pi = &Time::min;
	now.*pi = 22;
	pi = &Time::sec;
	now.*pi = 30;
	now.OutTime();

	now.hour = 12;
	now.min = 30;
	now.sec = 0;
	now.OutTime();

	return 0;
}