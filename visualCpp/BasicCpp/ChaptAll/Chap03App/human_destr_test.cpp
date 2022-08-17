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
		printf("%s ��ü �����ڰ� ȣ��Ǿ����ϴ�\n", this->name);
	}
	~Human() {
		printf("%s ��ü�� �ı��Ǿ����ϴ�\n", this->name);
		delete[] this->name;
	}
	void intro() {
		printf("�̸� = %s, ���� = %d\n", this->name, this->age);
	}
};

int main() {
	Human man("����ѹ��ź��̿͵η��", 13);
	man.intro();	
}