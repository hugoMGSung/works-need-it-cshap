#include <stdio.h>

class Int100 {
private:
	int num;
public:
	Int100(int a) try : num(a) {
		if (a <= 100) {
			num = a;
		}
		else {
			throw a;
		}
	}
	catch (int a) {
		printf("[ERROR] %d은 100보다 큼\n", a);
	}

	Int100& operator +=(int b) {
		if (num + b <= 100) {
			num += b;
		}
		else {
			throw num + b;
		}
		return *this;
	}
	void OutValue() {
		printf("%d", num);
	}
};

int main() {
	try
	{
		Int100 i(1003);
		i.OutValue();
	}
	catch (int n)
	{
		printf("무효한 객체");
	}	
	
	return 0;
}