#include <stdio.h>
#include <string.h>

class Human {
protected:
	char name[12];
	int age;
public:
	Human() { ; }
	Human(const char* aname, int aage) {
		strcpy(name, aname);
		age = aage;
	}
	void intro() {
		printf("�̸� : %s, ���� : %d\n", name, age);
	}
};

class Student : public Human {
protected:
	int stunum;
public:
	Student(const char* aname, int aage, int astunum) : Human(aname, aage) {
		/*strcpy(name, aname);
		age = aage;*/
		stunum = astunum;	
	}
	void study() {
		printf("���̴� ��, �̻��� ��, �̻� ��\n");
	}
	void report() {
		printf("�̸� : %s, ���� : %d��, �й� : %d ���� ����\n", name, age, stunum);
	}
	void intro() {		
		Human::intro();
		printf("�й� : %d, �̸� : %s\n", stunum, Human::name);
	}
};

class Graduate : public Student {
protected:
	char thesis[40];
public:
	Graduate(const char* aname, int aage, int astunum, const char* athesis) :
		Student(aname, aage, astunum) {
		strcpy(thesis, athesis);
	}
	void research() {
		printf("%s �� �����ϰ� ���� ����\n", thesis);
	}
};

class Boxer : public Human {
protected:
	int height, weight;
public:
	Boxer(const char* aname, int aage, int aheight, int aweight) :
		Human(aname, aage) {
		height = aheight;
		weight = aweight;
	}
	void intro() {
		//Human::intro();
		printf("Ű %dcm ������ %dkg �� %s �����Դϴ�\n", 
			height, weight, Human::name);
	}
	void fight() {
		puts("����Ʈ, ����Ʈ, µµ");
	}
};

int main() {
	/*Human sung("�����", 45);
	sung.intro();*/

	/*Student jin("������", 14, 12);
	jin.intro();
	jin.study();
	jin.report();
	*/
	Graduate sung("�����", 45, 9537556, "������ ���");
	sung.intro();
	sung.research();
	printf("\n");

	Boxer park("������", 61, 178, 65);
	park.intro();
	park.fight();
}