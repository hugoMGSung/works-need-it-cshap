#include <stdio.h>
#include <exception>
using namespace std;

void myunex() {
	puts("�ٽ� ���� �߻�");
	exit(-2);
}

void report() {
	//try
	//{
	//	// logic
	//}
	//catch (const std::exception&)
	//{
	//	// --
	//}
	///throw e;
}

void calc() throw(int) {
	// ...
	//throw "string";
	report();
	//try
	//{
	//	
	//}
	//catch (const std::exception&)
	//{
	//	// ----
	//}	
}

int main()
{
	set_terminate(myunex);

	try
	{
		calc();
	}
	catch (exception &e)
	{
		puts("������ ���� �߻�");
	}
	puts("���α׷� ����");
	return 0;
}