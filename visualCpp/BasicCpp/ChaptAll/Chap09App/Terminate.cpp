#include <stdio.h>
#include <exception>
#include <stdlib.h>

void myterm() {
	puts("���ܹ߻�");
	exit(-1);
}

int main() {	
	set_terminate(myterm);

	try {
		throw 1234;
	}
	catch (unsigned a)
	{
		printf("%d�� ���� ���� �߻�\n", a);
	}
}