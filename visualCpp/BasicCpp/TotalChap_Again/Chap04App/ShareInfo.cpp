#include <stdio.h>

class Exchange
{
private:
	static double rate;

public:
	static double GetRate() { return rate; }
	static void SetRate(double aRate) { rate = aRate; }
	double DollarToWon(double d) { return d * rate; }
	double WonToDollar(double w) { return w / rate; }
};
double Exchange::rate;

int main()
{
	Exchange::SetRate(1200);
	Exchange A, B;
	printf("1�޷��� %.0f���̴�.\n", A.DollarToWon(1.0));
	Exchange::SetRate(1150);
	printf("1�޷��� %.0f���̴�.\n", B.DollarToWon(1.0));
}