#include <iostream>
#include <fstream>
using namespace std;

int main() {
	ofstream f;

	f.open("C:\\Temp\\test.txt");
	
	if (f.is_open()) {
		f << "입력해 넣을 문자열 " << 3.141592 << endl;
		f.close();
	}
	else {
		cerr << "파일 열기 실패 " << endl;
	}

	ifstream fi;
	char str[128];
	int i = 0;

	fi.open("C:\\Temp\\test.txt");
	if (fi.is_open()) {
		fi.getline(str, 128); 
		cout << str << i << endl;
		fi.close();
	}
	else {
		cerr << "파일 열기 실패 " << endl;
	}

	return 0;
}