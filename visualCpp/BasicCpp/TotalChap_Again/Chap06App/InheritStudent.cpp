#include <stdio.h>
#include <string.h>

class Human
{
private:
	char name[12];
	int age;

public:
	Human(const char* aname, int aage) {
		strcpy(name, aname);
		age = aage;
	}
	void intro() {
		printf("ÀÌ¸§ = %s, ³ªÀÌ = %d\n", name, age);
	}
};

class Student : public Human
{
private:
	int stunum;

public:
	Student(const char* aname, int aage, int astunum) : Human(aname, aage) {
		stunum = astunum;
	}
	void study() {
		printf("ÀÌÀÌ´Â »ç, ÀÌ»ïÀº À°, ÀÌ»ç ÆÈ\n");
	}
};

int main()
{
	Human kim("±è»óÇü", 29);
	kim.intro();
	Student han("±èÇÑ°á", 15, 123456);
	han.intro();
	han.study();
}
