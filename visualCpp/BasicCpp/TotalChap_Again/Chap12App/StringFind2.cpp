#include <iostream>
#include <string>
using namespace std;

int main()
{
	string s1("starcraft");
	string s2("123abc456");
	string moum("aeiou");
	string num("0123456789");

	cout << "������ t:" << s1.find('t') << "��°" << endl;
	cout << "������ t:" << s1.rfind('t') << "��°" << endl;
	cout << "������ cra:" << s1.rfind("cra") << "��°" << endl;
	cout << "������ ����" << s1.find_first_of(moum) << "��°" << endl;
	cout << "������ ����" << s1.find_last_of(moum) << "��°" << endl;
	cout << "������ �����" << s2.find_first_not_of(num) << "��°" << endl;
	cout << "������ �����" << s2.find_last_not_of(num) << "��°" << endl;
}