#include <stdio.h>

class Some
{
private:
	int& total;
public:	
	Some(int& atotal) : total(atotal) {
		printf("%p", &atotal);
		printf("%p", &total);
	}
	void OutTotal() { printf("%d\n", total); }
};

int main()
{
	int value = 8;
	Some S(value);
	S.OutTotal();
}