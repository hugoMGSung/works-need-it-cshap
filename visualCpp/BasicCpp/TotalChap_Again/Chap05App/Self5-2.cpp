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
	const Time operator +(int s) const {
		Time t = *this;

		t.sec += s;

		t.min += t.sec / 60;
		t.sec %= 60;
		t.hour += t.min / 60;
		t.min %= 60;
		return t;
	}

	const Time operator *(int s) const {
		Time t = *this;

		int mid = (t.hour * 3600) + (t.min * 60) + t.sec;
		mid = mid * 2;

		t.hour = mid / 3600;
		t.min = (mid / 60) % 60;
		t.sec = mid % 60;

		return t;
	}
};

const Time operator +(int s, const Time& me) {
	return (me + s);
}

int main()
{
	/*Time now(11, 22, 33);
	now.OutTime();
	now = 1 + now;
	now = now + 1;
	now.OutTime();*/
	Time now(11, 22, 33);
	now.OutTime();
	now = now * 2;
	now.OutTime();
}
