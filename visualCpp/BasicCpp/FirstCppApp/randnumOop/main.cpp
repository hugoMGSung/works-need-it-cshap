#include <stdio.h>
#include "cursor.h"

class RandNum
{
private:
	int num;

public:
	RandNum() { randomize(); }
	void Generate() { num = random(100) + 1; }
	BOOL Compare(int input) {
		if (input == num) {
			printf("������ϴ�.\n");
			return TRUE;
		}
		else if (input > num) {
			printf("�Է��� ���ں��� �� �۽��ϴ�.\n");
		}
		else {
			printf("�Է��� ���ں��� �� Ů�ϴ�.\n");
		}
		return FALSE;
	}
};

class Ask
{
private:
	int input;

public:
	void Prompt() { printf("\n���� ���� ���ڸ� ���� ������.\n"); }
	BOOL AskNumber() {
		printf("���ڸ� �Է��ϼ���(���� ���� 999) : ");
		scanf("%d", &input);
		if (input == 999) {
			return TRUE;
		}
		return FALSE;
	}
	int GetInput() { return input; }
};

int main()
{
	RandNum R;
	Ask A;

	while (1) {
		R.Generate(); // ���Ƿ� �̵��ô� F12, Back Ctrl + -;
		A.Prompt();
		while (1) {
			if (A.AskNumber()) {
				exit(EXIT_SUCCESS);
			}
			if (R.Compare(A.GetInput())) {
				break;
			}
		}
	}
}