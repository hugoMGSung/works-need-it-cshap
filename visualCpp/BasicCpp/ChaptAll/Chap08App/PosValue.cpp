#include <iostream>
#include "cursor.h"
using namespace std;

template <typename T>
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