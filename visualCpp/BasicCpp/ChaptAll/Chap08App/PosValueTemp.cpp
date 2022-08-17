#include <iostream>
#include "cursor.h"
using namespace std;

template <typename T=int>
class PosValue {
private:
	int x, y;
	T value;
public:
	PosValue(int ax, int ay, T av) : x(ax), y(ay), value(av) { ; }
	void outValue() {
		gotoxy(x, y);
		cout << value << endl;
	}
};

template <> class PosValue<double> {
private:
	int x, y;
	double value;
public:
	PosValue(int ax, int ay, double av) : x(ax), y(ay), value(av) { ; }
	void outValue() {
		gotoxy(x, y);
		cout << "[" << value << "]" << endl;
	}
};

int main() {
	PosValue<> iv(10, 10, 2);
	PosValue<char> cv(25, 5,'C');
	PosValue<double> dv(30, 15, 3.14);
	iv.outValue();
	cv.outValue();
	dv.outValue();
}