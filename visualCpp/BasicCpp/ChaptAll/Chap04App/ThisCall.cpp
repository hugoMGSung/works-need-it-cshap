#include <stdio.h>

class Simple
{
private:
	int value;
public:
	Simple(int value) {
		this->value = value;
	}
	void OutValue() {
		printf("value = %d\n", this->value);
	}
	
};

int main()
{
	Simple A(1);
	Simple B(2);
	A.OutValue();
	B.OutValue();

	
}