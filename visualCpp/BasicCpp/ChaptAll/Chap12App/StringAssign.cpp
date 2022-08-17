#include <string>
#include <iostream>
using namespace std;

int main() {
	string s1("�ȳ��ϼ���~ ");
	string s2;

	s2 = "���Ի�";
	cout << s2 << endl;
	s2 = s1;
	cout << s2 << endl;

	s1 += "���迩!!";
	cout << s1 << endl;

	string s3;
	s3 = "s1: " + s1 + "s2: " + s2;
	cout << s3 << endl;

	string s4("1234567890");
	string s5("abcdefghijklmnop");
	string s6;

	s6.assign(s4, 3, 5);
	cout << s6 << endl;
	s6.append(s5, 3, 2);
	cout << s6 << endl;

	string s7("^_^");
	cout << s4.insert(5, "XXX") << endl;
	cout << s4.insert(8, s7) << endl;
	cout << s4.erase(5, 6) << endl;

	string s8 = "������ �Ϻ���";
	cout << s8 << endl;
	cout << s8.replace(7, 4, "���ѹα�") << endl;

	string s9("1234567890");
	string s10 = s9.substr(3, 4);

	cout << s10 << endl;

	string s11("aab");
	string s12("aaa");

	cout << (s11 == s11 ? "����" : "�ٸ���") << endl;
	cout << (s11 == s12 ? "����" : "�ٸ���") << endl;
	cout << (s11 > s12 ? "ũ��" : "�۴�") << endl;

	string s13("1234567");
	string s14("1234999");
	cout << (s13.compare(s14) == 0 ? "����" : "�ٸ���") << endl;
	cout << (s13.compare(0, 4, s14, 0, 4) == 0 ? "����" : "�ٸ���") << endl;

	string s15("HongKilDong");
	cout << (s15.compare("HongKilDong") == 0 ? "����" : "�ٸ���") << endl;

	string s16("string class find function.");
	string s17("func");

	cout << endl;
	cout << s16.find('i') << "��°" << endl;
	cout << s16.find('i', 4) << "��°" << endl;
	cout << s16.find("ass") << "��°" << endl;
	cout << s16.find('K') << "��°" << endl;
	cout << s16.find(s17) << "��°" << endl;

	string s18("Starcraft");
	cout << s18.find('t') << "��°" << endl;
	cout << s18.rfind('t') << "��°" << endl;
	cout << s18.find_first_of("aeiou") << endl;
	cout << s18.find_last_of("aeiou") << endl;
	cout << s18.find_first_not_of("aeiou") << endl;


	return 0;
}