#include <stdio.h>
#include <string.h>

class Human {
private:
	char *name;
	int age;
public:
	Human(const char* aname = "", int aage = 0) {
		name = new char[strlen(aname) + 1];
		strcpy(name, aname);
		age = aage;
	}
	~Human() {
		delete[] name;
	}
	void intro() {
		printf("�̸� %s, ���� %d\n", name, age);
	}
};

int main() {
	/*Human h = { "�����", 45 };
	h.intro();*/

	Human arFriend[10];
	arFriend[0] = Human("������", 49);
	arFriend[1] = Human("������", 34);
	arFriend[2] = Human("�ڻ�", 23);

	for (int i = 0; i < 10; i++)
	{
		Human* pFriend;
		pFriend = &arFriend[i];
		pFriend->intro();
	}

	return 0;
}