#include <stdio.h>
#include <exception>
using namespace std;

void myunex() {
	puts("핵심 에러 발생");
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
		puts("정수형 예외 발생");
	}
	puts("프로그램 종료");
	return 0;
}