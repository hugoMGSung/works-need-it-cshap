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
	bool operator ==(const Time& other) const {
		return (hour == other.hour && min == other.min && sec == other.sec);
	}
	bool operator !=(const Time& other) const {
		return !(*this == other);
	}
	bool operator >(const Time& other) const {
		if (hour > other.hour) return true;
		if (hour < other.hour) return false;
		if (min > other.min) return true;
		if (min < other.min) return false;
		if (sec > other.sec) return true;
		return false;
	}
	bool operator <(const Time& other) const {
		return !(*this > other);
	}
	bool operator >=(const Time& other) const {
		return (*this == other || *this > other);
	}
	bool operator <=(const Time& other) const {
		return !(*this > other);
	}
};

int main() {
	Time t1(15, 16, 56);
	Time t2(15, 16, 50);
	Time t3(17, 30, 0);

	(t1 != t2) ? printf("�� �ð��� �ٸ���.\n") : printf("�� �ð��� ����.\n");
	(t1 == t3) ? printf("�� �ð��� ����.\n") : printf("�� �ð��� �ٸ���.\n");

	(t1 > t2) ? printf("t1�� ũ��.\n") : printf("t2�� ũ��.\n");
}