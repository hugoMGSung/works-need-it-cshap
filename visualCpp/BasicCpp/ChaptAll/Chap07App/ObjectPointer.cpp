#include <stdio.h>
#include <string.h>

class Human {
protected:
	char name[12];
	int age;
public:
	Human() {}
	Human(const char* aname, int aage) {
		strcpy(name, aname);
		age = aage;
	}
	virtual void intro() {
		printf("�̸� = %s, ���� = %d\n", name, age);
	}
};

class Student : public Human {
protected:
	int stunum;
public:
	Student() {}
	Student(const char* aname, int aage, int astunum) : Human(aname, aage) {
		stunum = astunum;
	}
	virtual void intro() {
		printf("%d�й� %s�Դϴ�.\n", stunum, name);
	}
	virtual void study() {
		printf("���̴� ��, �̻��� ��, �̻� ��\n");
	}
};

int main() {
	Human h("����", 10);
	Student s("���л�", 15, 1234567);
	Human *pH;
	Student *pS;

	pH = &h; // name(����), age(10) <= name(����), age(10)
	pH->intro();
	// pS = &s; // name(���л�), age(15), stunum(1234567) <= name(���л�), age(15), stunum(1234567)
	pH = &s; // name(���л�), age(15) <= name(���л�), age(15), stunum(1234567)
	pH->intro();	
	//pS = &h; // name(����), age(10), stunum(???????) <= name(����), age(10)
	pS = (Student*)&h;
	pS->intro();
	/*pS = (Student*)&h;
	pS->intro();*/

	return 0;
}