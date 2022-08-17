#include <vector>
#include <numeric>
#include <algorithm>
#include <iostream>
using namespace std;

void func(int a) { cout << "func - int " << endl; }
void func(double* p) { cout << "func - double " << endl; }

class TEST {
public:
	void print() {
		std::cout << n1 << ", " << s1 << std::endl;
	}
//private:
	int n1 = 100;
	std::string s1 = "first";
};

class DefaultTest {
public:
	DefaultTest() = default;
	DefaultTest(const DefaultTest&) = default;
	~DefaultTest() = default;
	DefaultTest& operator=(const DefaultTest&) = default;
};

class DeleteTest {
public:
	DeleteTest(const DeleteTest&) = delete;
	DeleteTest& operator=(const DeleteTest&) = delete;
	void* operator new(size_t) = delete; // new로 할당하지 못하도록 한다
};

struct StrctTest {
	void f(int i) { std::cout << i << std::endl; }
	void f(double d); // = delete;
};

class Base {
	virtual void foo(int i);
	virtual void foop(int i) final;
};

class Derived : public Base {
	virtual void foo(int i) override;
	// virtual void foo(double d) override; // Base에 정의가 없음
	// virtual void foop(int i) override; // Base에 final 지정
};

//template <class T>
//class vector {
//public:
//	vector(std::initializer_list<T>);
//};

int sum(std::initializer_list<int> li) {
	return accumulate(li.begin(), li.end(), 0);
}

int main() {
	func(static_cast<double*>(0)); // func(double *p)
	func(0);   // func(int a)
	func(NULL);    // func(int a)
	func(nullptr);    // func(double *p)

	char* ch = nullptr;    // ch에 널 포인터 대입
	cout << "sizeof(nullptr) : " << sizeof(nullptr) << endl;
	cout << "typeid(nullptr) : " << typeid(nullptr).name() << endl;

	TEST test{ 200, "test" };
	test.print();

	std::vector<int> v{ 1,2,3 };

	for (auto& atom : v)
	{
		cout << "vector " << atom << ", ";
	}
	cout << endl;

	auto result = sum({1, 2, 3, 4});
	cout << "result = " << result << endl;

	//int i = 11;
	//StrctTest stest;
	//stest.f(i);

	//double d = 11.0;
	//stest.f(d); // = delete 에러

	const string sample = "Hello";
	vector<string> v1;
	v1.push_back(sample);
	v1.push_back({ sample[0], 'e' });
	cout << "v1 text is ";
	for (auto& atom : v1)
	{
		cout << atom;
	}
	cout << endl;

	vector<string> v2;
	v2.emplace_back(sample);
	v2.emplace_back(10, 'a');
	cout << "v2 text is ";
	for (auto& atom : v2)
	{
		cout << atom;
	}
	cout << endl;

	// end of main
	return 0;
}