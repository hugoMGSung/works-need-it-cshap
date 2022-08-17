#include <stdio.h>

int Add(int a, int b);
int Add(int a, int b, int c);
double Add(double a, double b);
double Add(double a, int b);

int main()
{
	printf("1 + 2 = %d\n", Add(1, 2));
	printf("3 + 4 + 5 = %d\n", Add(3, 4, 5));
	printf("1.414 + 2.54 = %f\n", Add(1.414, 2.54));
	printf("3.14 + 2 = %f\n", Add(3.14, 2));
}

int Add(int a, int b)
{
	return a + b;
}

int Add(int a, int b, int c)
{
	return a + b + c;
}

double Add(double a, double b)
{
	return a + b;
}

double Add(double a, int b)
{
	return double(a + b);
}
