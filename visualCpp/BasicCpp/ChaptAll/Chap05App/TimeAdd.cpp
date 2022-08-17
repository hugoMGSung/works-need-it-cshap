#include <stdio.h>

class Time {
private:
	int hour, min, sec;
public:
	Time() { ; }
	Time(int h, int m, int s) : hour(h), min(m), sec(s) { ; }
	void OutTime() {
		printf("%d:%d:%d\n", hour, min, sec);
	}
	const Time AddTime(const Time& other) const {
		Time t;
		t.sec = sec + other.sec;  // 35 + 56 = 91 / 60  = 1(min) 31(sec)
		t.min = min + other.min;
		t.hour = hour + other.hour;

		t.min += t.sec / 60;
		t.sec %= 60;
		t.hour += t.min / 60;
		t.min %= 60;

		return t;
	}
};

int main() {
	Time t1(1, 40, 32), t2(2, 21, 33);
	Time t3;
	t1.OutTime();
	t2.OutTime();

	t3 = t1.AddTime(t2);
	t3.OutTime();
}