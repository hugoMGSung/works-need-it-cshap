#include <stdio.h>
#include <string.h>

class Human {
protected:
	char name[12];
	int age;
public:
	Human(const char* aname, int aage) {
		strcpy(name, aname);
		age = aage;
	}
	void intro() {
		printf("%s은 %d살 입니다\n", name, age);
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
		printf("%d번, %s입니다\n", stunum, name);
	}
};

int main() {
	Human h("성명건", 45);
	Student s("최상식", 26, 25);
	Human* pH;
	Student* pS;

	printf("Human size %d / Student size %d\n", sizeof(h), sizeof(s));

	pH = &h;
	pH->intro();
	pS = &s;
	pS->intro();
	pH = &s;
	pH->intro();
}