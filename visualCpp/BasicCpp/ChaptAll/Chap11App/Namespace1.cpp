#include <stdio.h>
#include <iostream>
using namespace std;

class OtherClass {
public:
	void OutTime() { printf("~~"); }
};

namespace A {
	double value;
}

namespace B {
	int value;
}

using namespace B;

int value;

int main() {
	A::value = 3.14159;
	B::value = 3;	

	return 0;
}