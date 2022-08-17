#include <stdio.h>

class Some
{
private:
	const int total;
public:	
	Some(int atotal) : total(atotal) { }
	void OutTotal() { printf("%d\n", total); }
};

int main()
{
	Some S(5);
	S.OutTotal();
}