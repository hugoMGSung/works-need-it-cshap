#include <stdio.h>

class Time
{
private:
	int hour, min, sec;

public:
	Time(int h, int m, int s) {
		hour = h;
		min = m;
		sec = s;
	}

	/*explicit*/ Time(int abssec) {
		hour = abssec / 3600;
		min = (abssec / 60) % 60;
		sec = abssec % 60;
	}

	Time(double d) {
		// ~~~
		hour = int(d) % 24;
		min = int((d - int(d) * 100)) % 60;
		sec = 0;
		// ...
	}

	operator int() {
		return hour * 3600 + min * 60 + sec;
	}

	void OutTime() {
		printf("현재 시간은 %d:%d:%d입니다.\n", hour, min, sec);
	}
};

void printTime(Time when)
{
	when.OutTime();
}

int main()
{
	/*Time cur(12, 34, 45);
	cur.OutTime();
	Time noon(40000);
	Time now = 60000;
	now.OutTime();
	now = 70000;
	now.OutTime();

	printTime(80000);*/
	Time now(40000);
	now.OutTime();

	int spanTime = now;
	printf("spanTime = %d\n", spanTime);
}