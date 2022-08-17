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
		hour = h; min = m; sec = s;
		return *this;
	}
	const Time AddTime(const Time& other) const {
		Time t;
		t.sec = sec + other.sec;
		t.min = min + other.min;
		t.hour = hour + other.hour;

		t.min += t.sec / 60;
		t.sec %= 60;
		t.hour += t.min / 60;
		t.min %= 60;
		return t;
	}
};

int main()
{
	Time t1(1, 10, 20);
	Time t2(2, 20, 30);
	Time t3;
	Time t4;

	t3 = t1.AddTime(t2).SetTime(11, 23, 57);
	t3.OutTime();
}