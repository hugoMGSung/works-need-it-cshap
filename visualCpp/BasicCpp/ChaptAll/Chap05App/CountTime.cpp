#include <iostream>
using namespace std;

class Time {
	friend ostream& operator << (ostream& c, const Time& T);
	friend ostream& operator << (ostream& c, const Time *pT);
private:
	int hour, min, sec;
public:
	Time() { }
	Time(int h, int m, int s) { hour = h; min = m; sec = s; }
	void OutTime() const {
		printf("%d:%d:%d\n", hour, min, sec);
	}

};

ostream& operator << (ostream& c, const Time& T) {
	c << T.hour << ":" << T.min << ":" << T.sec;
	return c;
}

ostream& operator << (ostream& c, const Time* pT) {
	c << pT->hour << ":" << pT->min << ":" << pT->sec; // 
	return c;
}

int main() {
	Time now(10, 22, 5);
	Time* pLunchTime = new Time(12, 30, 0);

	cout << "현재 시간은" << now << " 입니다" << endl;
	cout << "점심 시간은" << pLunchTime << " 입니다" << endl;

	delete pLunchTime;
}