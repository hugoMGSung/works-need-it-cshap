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
	Exchange::SetRate(1.2);
	Exchange A, B;
	printf("1�޷��� %.0f���̴�.\n", A.DollarToWon(1200));
	Exchange::SetRate(100.0);
	printf("1200���� %.0f�޷��̴�.\n", B.WonToDollar(1200));
}