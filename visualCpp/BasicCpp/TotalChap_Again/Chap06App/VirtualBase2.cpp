#include <stdio.h>

class A
{
protected:
	int a;
public:
	A(int aa) { a = aa; }
};

class B : virtual public A
{
protected:
	int b;
public:
	B(int aa, int ab) : A(aa) { b = ab; }
};

class C : virtual public A
{
protected:
	int c;
public:
	C(int aa, int ac) : A(aa) { c = ac; }
};

class D : public B, public C
{
protected:
	int d;
public:
	D(int aa, int ab, int ac, int ad) : A(aa), B(aa, ab), C(aa, ac) { d = ad; }
	void fD() {
		b = 1;
		c = 2;
		a = 3;
	}
};

int main()
{
	D d(1, 2, 3, 4);
}
