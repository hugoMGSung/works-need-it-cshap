#include <stdio.h>
#include <limits>
using namespace std;

int main() {
	const char* str = "Korea";
	int* pi;
	double d = 2147483647.99999; // 123.456;
	int i;

	//double dd = numeric_limits<double>::max();
	//int di = numeric_limits<int>::max();
	//printf("%d\n\n", di);
	//printf("%f\n\n", dd);
	//i = static_cast<int>(d);
	//printf("%d\n", i);
	//pi = static_cast<int*>(str);
	pi = (int*)str;
	//printf("%d %x\n", *pi, *pi);
	printf("%x %x\n", *pi, *(pi + 1));
}