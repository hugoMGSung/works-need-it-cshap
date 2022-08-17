#include <stdio.h>
#include <string.h>

class Human {
private:
	char* name;
	int age;
public:
	Human(const char* name, int age) {
		this->name = new char[strlen(name) + 1];
		strcpy(this->name, name);
		this->age = age;
		printf("%s 객체 생성자가 호출되었습니다\n", this->name);
	}
	~Human() {
		printf("%s 객체가 파괴되었습니다\n", this->name);
		delete[] this->name;
	}
	void intro() {
		printf("이름 = %s, 나이 = %d\n", this->name, this->age);
	}
};

int main() {
	Human man("김수한무거북이와두루미", 13);
	man.intro();	
}