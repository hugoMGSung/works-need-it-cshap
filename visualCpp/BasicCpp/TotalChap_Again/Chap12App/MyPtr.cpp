#include <string>
#include <iostream>
using namespace std;

template <typename T>
class myptr
{
private:
	T* p;

public:
	explicit myptr(T* ap) : p(ap) { }
	~myptr() { delete p; }
	T& operator *() const { return *p; }
	T* operator ->() const { return p; }
};

int main()
{
	myptr<string> pStr(new string("AutoPtr Test"));

	cout << *pStr << endl;
	cout << "±æÀÌ = " << pStr->size() << endl;
}