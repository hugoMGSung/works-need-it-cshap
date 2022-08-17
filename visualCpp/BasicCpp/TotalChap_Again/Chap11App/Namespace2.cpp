#include <stdio.h>

int value;					// 전역 네임 스페이스 소속
namespace A {
	int value;				// A 소속
}

int main()
{
	int value;				// main 소속

	value = 1;				// 지역 변수 value
	::value = 2;			// 전역 네임 스페이스의 value
	A::value = 3;			// A 네임 스페이스의 value
}