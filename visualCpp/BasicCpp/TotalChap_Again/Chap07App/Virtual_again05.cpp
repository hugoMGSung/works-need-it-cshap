#include <stdio.h>
#include <string.h>
#include <iostream>
using namespace std;

class Human {
protected:
	char name[12];
	int age;
public:
	Human(const char* aname, int aage) {
		strcpy(name, aname);
		age = aage;
	}
	virtual void intro() {
		printf("%s�� %d�� �Դϴ�\n", name, age);
	}
};

class Student : public Human {
protected:
	int stunum;
public:
	Student(const char* aname, int aage, int astunum) : Human(aname, aage) {
		stunum = astunum;
	}
	void intro() {
		printf("%d��, %s�Դϴ�\n", stunum, name);
	}
};

int main() {
	Human h("�����", 45);
	Student s("�ֻ��", 26, 25);
	Human* pH;
	Student* pS;

	int sel = 0;
	cout << "���ϴ� ���� ������(1:Human, 2:Student) ";
	cin >> sel;

	if (sel == 1) 
		pH = &h;
	else if (sel == 2)
		pH = &s;
	else {
		cout << "�´� ���� �����ϴ�" << endl;
		exit(-1);
	}

	pH->intro();
}