#include <stdio.h>

namespace UTIL {
	int value;
	double score;
	void sub() { puts("sub routine"); }
}

using namespace UTIL;

int main() {
	value = 3;
	score = 1.2;
	sub();
}