#include <stdio.h>

class Time
{
private:
	int hour, min, sec;

public:
	Time(int h, int m, int s) {
		SetTime(h, m, s);
	}

	void SetTime(int h, int m, int s) {
		hour = h;
		min = m;
		sec = s;
	}

	void OutTime() const {
		printf("현재 시간은 %d:%d:%d입니다.\n", hour, min, sec);
	}
};

int main()
{
	Time now(10, 54, 16);
	now.OutTime();
	now.SetTime(11, 15, 00);
	now.OutTime();

	const Time getoff(17, 30, 00);
	// getoff.SetTime(18, 50, 20);
	getoff.OutTime();
}