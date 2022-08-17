#include <stdio.h>
#include <string.h>

class Human {
private:
	char name[12];
	int age;
public:
	Human(const char* aname, int aage) {
		strcpy(name, aname);
		age = aage;
	}
	void intro() {
		printf("이름 = %s, 나이 = %d\n", name, age);
	}

	char* GetName() { return name; }
	void SetName(const char* aname) {
		if (strlen(aname) < 12) {
			strcpy(name, aname);
		}
		else {
			strcpy(name, "");
		}
	}
	int GetAge() { return age; }
	void SetAge(int aage) {
		if (aage >= 0 && aage <= 120) {
			age = aage;
		}
		else {
			age = 0;
		}
	}
};

int main() {
	Human sung("성명건", 45);
	sung.SetName("Hugo Sung");
	sung.SetAge(46);
	sung.intro();

}