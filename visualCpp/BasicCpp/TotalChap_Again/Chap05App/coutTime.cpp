#include <stdio.h>
#include <iostream>
using namespace std;

class Time
{
	friend ostream &operator <<(ostream &c, const Time &T);
	friend ostream &operator <<(ostream &c, const Time *pT);
private:
	int hour, min, sec;

public:
	Time() { }
	Time(int h, int m, int s) { hour = h; min = m; sec = s; }
	void OutTime() {
		printf("%d:%d:%d\n", hour, min, sec);
	}
};

ostream &operator <<(ostream &c, const Time &T)
{
	c << T.hour << "시" << T.min << "분" << T.sec << "초";
	return c;
}

ostream &operator <<(ostream &c, const Time *pT)
{
	c << *pT;
	return c;
}

int main()
{
	Time now(1, 2, 3);
	Time *pTime;

	pTime = new Time(4, 5, 6);
	cout << "현재 시간은 " << now << "입니다." << endl;
	cout << "현재 시간은 " << pTime << "입니다." << endl;
	delete pTime;
}