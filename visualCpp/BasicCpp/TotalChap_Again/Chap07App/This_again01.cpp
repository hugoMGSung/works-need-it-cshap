#include <stdio.h>
#include <string.h>

class thisClass {
private:
	int num;
public:
	thisClass() { ; }
	void outThis() {
		printf("thisClass 林家 0x%p\n", this);
	}

	thisClass* returnThis() {
		return this;
	}
};

int main(void) {
	thisClass t;

	printf("t 林家 : 0x%p\n", &t);
	t.outThis();
	printf("t.returnThis() : 0x%p\n", t.returnThis());

	return 0;
}