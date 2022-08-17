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
	Time SetTime(int h, int m, int s) {
		hour = h;
		min = m;
		sec = s;
		return *this;
	}

	const Time operator ++() {
		sec++;
		min += sec / 60;
		sec %= 60;
		hour += min / 60;
		min %= 60;
		return *this;
	}
	/*const*/ Time operator ++(int dummy) {
		Time t = *this;
		++* this;
		return t;
	}
};

int main()
{
	Time t1(11, 24, 10);
	Time t2;

	t2 = ++t1;
	t1.OutTime();
	t2.OutTime();
	t2 = (t1++).SetTime(12, 55, 12);
	t1.OutTime();
	t2.OutTime();
}