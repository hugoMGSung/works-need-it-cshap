#include <iostream>
using namespace std;

int main() {
	int i;
	char str[128];
	char ch;

	cout << "정수를 입력하세요 : ";
	cin >> i;

	if (cin.good()) {
		cout << "입력된 정수 : " << i << endl;
	}
	else {
		cerr << "실패 " << endl;
	}
	
	//cin.get(ch);

	///*cout << "문자열을 입력하세요 : ";
	//cin >> str;
	//cout << "입력된 문자열 : " << str << endl;*/
	//cout << "문자를 입력 : ";
	//cin.get(ch);
	//cout << "입력된 문자 : " << ch << endl;
	//cin.get(ch);

	//cout << "공백포함 문자열 입력 : ";
	//cin.getline(str, 128);
	//cout << "입력된 문자열 : " << str << endl;

	

	return 0;
}