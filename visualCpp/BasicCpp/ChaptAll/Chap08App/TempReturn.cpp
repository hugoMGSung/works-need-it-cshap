#include <stdio.h>

template <typename T>
T max(T a, T b) {
	return (a > b) ? a : b;
}

template <typename T>
T cast(int s) {
	return (T)s;
}

int main() {
	int a = max(1, 2);
	double b = max(1.1, 2.2);
	double c = max(double(2), 3.14);

	int d = max(2, int(3.14));

	printf("d = %d\n", d);
}