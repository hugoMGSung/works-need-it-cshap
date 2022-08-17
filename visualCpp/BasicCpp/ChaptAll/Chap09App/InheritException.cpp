#include <stdio.h>

class Exception {
protected:
	int number;
public:
	Exception(int n) : number(n) { ; }
	virtual void PrintError() {
		printf("[ERROR] %d는 음수로 오류\n", number);
	}
};

class TooBigException : public Exception {
public:
	TooBigException(int n) : Exception(n) { ; }
	virtual void PrintError() {
		printf("[ERROR] %d는 너무 큽니다. 100보다 작아야\n", number);
	}
};

class OddException : public TooBigException {
public:
	OddException(int n) : TooBigException(n) { }
	void PrintError() {
		printf("[ERROR] %d는 홀수입니다. 짝수요망\n", number);
	}
};

int main() {
	int n;

	while (true)
	{
		try
		{
			printf("수를 입력(종료 0) : ");
			scanf("%d", &n);
			if (n == 0) break;
			if (n < 0) throw Exception(n);
			if (n > 100) throw TooBigException(n);
			if (n % 2 != 0) throw OddException(n);

			printf("%d는 규칙에 맞는 수입니다\n", n);
		}
		catch (Exception &e)
		{
			e.PrintError();
		}
	}
}