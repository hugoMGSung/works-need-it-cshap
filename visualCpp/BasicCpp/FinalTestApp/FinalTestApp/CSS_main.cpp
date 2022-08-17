#include <stdio.h>
#include <conio.h>
#include <math.h>
#include "cursor.h"
#include <iostream>

using namespace std;

class Shape
{
protected:
	int x, y;
public:
	Shape(int ax, int ay) { x = ax; y = ay; }
	virtual void draw() {
		gotoxy(x, y); putch('*');
	}
	virtual void clear() {
		clrscr();
	}
};

int main(void) {
	int i, j;
	int a = 4;
	int input;
	Shape* pS = new Shape(10, 10);

	while (true)
	{
		gotoxy(10, 1);
		printf("출력도형 선택(0:종료, 1:점, 2:원, 3:사각형, 4:삼각형, 5:별) : ");
		cin >> input;
		pS->clear();

		switch (input)
		{
		case 0:
			exit(0);
			break;
		case 1:
			printf("*");
			break;
		case 2:
			for (i = -2 * a; i <= 2 * a; i += 2) {
				for (j = -a; j <= a; j++) {
					if ((i * i + j * j) >= a * a - a / 1.3 && (i * i + j * j) <= a * a + a / 1.3)
						printf("*");
					else
						printf(" ");
				}
				printf("\n");
			}
			break;
		case 3:
			for (i = 1; i < a; i++) {
				printf("***\n");
			}
			break;
		case 4:
			for (int i = 0; i < a; i++) {
				for (int j = a - 1; j > i; j--) {
					printf(" ");
				}

				for (int j = 0; j < 2 * i + 1; j++) {
					printf("*");
				}
				printf("\n");
			}
			break;

		}
	}

	delete pS;
	return 0;
}
