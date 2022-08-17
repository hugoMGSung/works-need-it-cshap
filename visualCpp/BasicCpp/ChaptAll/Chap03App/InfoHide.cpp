#include <stdio.h>

class Time {	
private:
	int hour, min, sec;
public:	
	Time(int h, int m, int s) {
		SetHour(h);
		SetMinute(m);
		SetSecond(s);
	}

	int GetHour() { return hour; }
	void SetHour(int h) {
		if (h >= 0 && h < 24) {
			hour = h;
		}
		else {
			hour = 0;
		}
	}

	int GetMinute() { return min; }
	void SetMinute(int m) {
		if (m >= 0 && m < 60) {
			min = m;
		}
		else {
			min = 0;
		}
	}

	int GetSecond() { return sec; }
	void SetSecond(int s) {
		if (s >= 0 && s < 60) {
			sec = s;
		}
		else {
			sec = 0;
		}
	}

	void OutTime() {
		printf("현재 시간은 %d:%d:%d 입니다\n", hour, min, sec);
	}
};

int main() {
	Time now(14, 2, 24);
	now.OutTime();

	now.SetHour(40);
	now.OutTime();

	now.SetHour(10);
	now.SetMinute(20);
	now.SetSecond(14);
	now.OutTime();

	return 0;
}