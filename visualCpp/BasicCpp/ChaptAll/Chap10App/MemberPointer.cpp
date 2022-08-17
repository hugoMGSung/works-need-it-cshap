#include <stdio.h>

class MyClass {
public:
	int i, j;
	double d;
};

int main() {
	MyClass C;
	int MyClass::* pi;
	double MyClass::* pd;
	int num;

	/*int* pin;
	int in;
	pin = &in;*/

	pi = &MyClass::i;
	C.*pi = 10;
	pi = &MyClass::j;
	C.*pi = 300;
	pd = &MyClass::d;
	C.*pd = 3.14;

	//pi = &MyClass::d;
	//pd = &MyClass::i;
	printf("%d, %d, %f\n", C.i, C.j, C.d);
}