#include <stdio.h>
#include <string.h>

class Human {
private:
	char* name;
	int age;
public:
	Human(const char* aname, int aage) {
		name = new char[strlen(aname) + 1];
		strcpy(name, aname);
		age = aage;
		printf("%s 객체 생성자가 호출되었습니다\n", name);
	}
	~Human() {
		printf("%s 객체가 파괴되었습니다\n", name);
		delete[] name;
	}
	void intro() {
		printf("이름 = %s, 나이 = %d\n", name, age);
	}
};

int main() {
	Human boy("김수한무거북이와두루미", 12);
	boy.intro();	

	Human *leo = new Human("레오나르도 디카프리오", 47);
	leo->intro();
	delete leo;
}