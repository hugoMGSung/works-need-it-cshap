#include <string>
#include <iostream>
using namespace std;

int main() {
	string s("C++ String ��Ʈ��");

	cout << s << "���ڿ� ���� : " << s.size() << endl;
	cout << s << "���ڿ� ���� : " << s.length() << endl;
	cout << s << "���ڿ� �Ҵ���� : " << s.capacity() << endl;
	cout << s << "���ڿ� �ִ���� : " << s.max_size() << endl;

	cout << boolalpha << s.empty() << endl;

	s.clear();
	cout << s << endl;

	printf("%s\n", "Hello");

	return 0;
}