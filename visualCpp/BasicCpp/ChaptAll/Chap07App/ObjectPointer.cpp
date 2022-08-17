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
		printf("이름 = %s, 나이 = %d\n", name, age);
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
		printf("%d학번 %s입니다.\n", stunum, name);
	}
	virtual void study() {
		printf("이이는 사, 이삼은 육, 이사 팔\n");
	}
};

int main() {
	Human h("김사람", 10);
	Student s("이학생", 15, 1234567);
	Human *pH;
	Student *pS;

	pH = &h; // name(김사람), age(10) <= name(김사람), age(10)
	pH->intro();
	// pS = &s; // name(이학생), age(15), stunum(1234567) <= name(이학생), age(15), stunum(1234567)
	pH = &s; // name(이학생), age(15) <= name(이학생), age(15), stunum(1234567)
	pH->intro();	
	//pS = &h; // name(김사람), age(10), stunum(???????) <= name(김사람), age(10)
	pS = (Student*)&h;
	pS->intro();
	/*pS = (Student*)&h;
	pS->intro();*/

	return 0;
}