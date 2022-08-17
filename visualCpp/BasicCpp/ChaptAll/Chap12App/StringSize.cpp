#include <string>
#include <iostream>
using namespace std;

int main() {
	string s("C++ String 스트링");

	cout << s << "문자열 길이 : " << s.size() << endl;
	cout << s << "문자열 길이 : " << s.length() << endl;
	cout << s << "문자열 할당길이 : " << s.capacity() << endl;
	cout << s << "문자열 최대길이 : " << s.max_size() << endl;

	cout << boolalpha << s.empty() << endl;

	s.clear();
	cout << s << endl;

	printf("%s\n", "Hello");

	return 0;
}