#pragma once

class Time {
private:
	int hour, min, sec;

public:
	Time(int h, int m, int s);
	//void SetTime(int h, int m, int s);
	void OutTime();
};