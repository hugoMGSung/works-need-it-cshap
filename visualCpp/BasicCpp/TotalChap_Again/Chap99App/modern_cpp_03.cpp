#include <math.h>
#include <vector>
#include <algorithm>
#include <functional>
#include <iostream>
using namespace std;

constexpr double pow(double x, size_t y) {
	return y != 1 ? x * pow(x, y - 1) : x;
}

template <typename Func>
void Test(Func func) {
	func();
}

std::function<void()> ff() {
	std::string str("lambda");
	return [=] { std::cout << "Hello, " << str << std::endl; };
}

int wmain(int argc, wchar_t* argv[]) {
	double a = pow(2.0, 2);
	double b = pow(3.0, 6);

	cout << "a = " << a << ", b = " << b << endl;

	[] // lambda caputure
	() // 함수 인수정의
	{} // 함수의 본체
	(); // 함수 호출;

	[] {}; // 기본 람다
	[] {std::cout << "Hello, TechDay!" << std::endl; }();

	auto func = [] {std::cout << "Hello, Lamdba second!" << std::endl; };
	func();

	auto func2 = [] {std::cout << "Diablo is the great game!" << std::endl; };
	Test(func2);

	auto func3 = [] (int n) {std::cout << "Number is " << n << std::endl; };
	func3(333);

	auto funcf = []() -> float { return 3.14; };
	float rst = funcf();
	cout << "result is " << rst << endl;

	std::vector<int> v1;
	v1.push_back(10);
	v1.push_back(20);
	v1.push_back(30);
	std::for_each(v1.begin(), v1.end(), [](int n) { std::cout << n << ", "; });
	cout << endl;

	auto funcz = ff();
	funcz();

	return 0;
}