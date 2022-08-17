#include <stdio.h>

class Time
{
private:
	int hour, min, sec;

public:
	Time() { }
	Time(int h, int m, int s) { hour = h; min = m; sec = s; }
	void OutTime() {
		printf("%d:%d:%d\n", hour, min, sec);
	}
	const Time operator +=(int s) {
		sec += s;

		min += sec / 60;
		sec %= 60;
		hour += min / 60;
		min %= 60;
		return *this;
	}
	const Time operator +(int s) const {
		Time t = *this;
		t += s;
		return t;
	}
};

int main()
{
	Time now(11, 22, 33);
	now.OutTime();
	now = now + 2;
	now += 40;
	now.OutTime();
}
