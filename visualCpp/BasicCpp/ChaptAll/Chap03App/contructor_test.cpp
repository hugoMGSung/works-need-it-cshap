#include <stdio.h>
#include <string.h>

class Human {
private:
	char name[12];
	int age;

public:
	// ������
	Human(const char* name, int age) {
		strcpy(this->name, name);
		this->age = age;
	}

	void intro() {
		printf("�̸� = %s, ���� = %d\n", this->name, this->age);
	}
};

int main() {
	Human h = Human("�����", 44);
	h.intro();

	return 0;
}