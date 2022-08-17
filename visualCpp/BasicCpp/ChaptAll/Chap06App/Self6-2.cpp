#include <stdio.h>
#include <string.h>

class Date {
private:
	int year, month, day;
public:
	Date(int y, int m, int d) : year(y), month(m), day(d) { }
	void OutDate() { printf("%d/%d/%d", year, month, day); }
};

class Human {
private:
	char name[12];
	int age;
	Date birth;
public:
	Human(const char* aname, int aage,
		int y, int m, int d) : birth(y, m, d) {
		strcpy(name, aname);
		age = aage;
	}
	void intro() {
		printf("이름 %s, 나이 %d\n", name, age);
		printf("생일 : ");
		birth.OutDate();
		printf("\n");
	}
};

int main() {
	Human kim("김상형", 29, 1989, 6, 29);
	kim.intro();
}