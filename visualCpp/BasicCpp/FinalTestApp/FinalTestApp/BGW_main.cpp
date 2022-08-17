/* 배기웅 CPP TEST SOURCE */

#include <stdio.h>
#include <conio.h>
#define _USE_MATH_DEFINES
#include <math.h>
#include "cursor.h"
#include <iostream>
using namespace std;

class Shape
{
protected:
	int x, y;
	int count = 0;
	int limit = 15;
	int write = 1;
public:
	Shape(int ax, int ay) { x = ax; y = ay; }

	int cnt = 0;

	virtual void draw() {
		gotoxy(x, y); putch('*');
	}

	virtual void square() {
		cnt = count;
		for (cnt; cnt < limit; cnt++)
		{
			gotoxy(x, y + cnt);

			for (int i = 0; i < (limit*2); i++) {
				putch('*');
			}
			cout << endl;
		}
	}

	virtual void triangle() {
		cnt = count;
		write = 1;

		for (cnt; cnt < limit; cnt++) {
			gotoxy(x + limit - cnt, y + cnt);
			
			for (int i = 0; i < write; i++) {
				putch('*');
			}
			cout << endl;
			write += 2;
		}
	}

	virtual void inv_triangle() {
		cnt = count;
		write = 1;

		for (cnt; cnt < limit; cnt++) {
			gotoxy(x + limit - cnt, y + (limit + 2) - cnt);

			for (int i = 0; i < write; i++) {
				putch('*');
			}
			cout << endl;
			write += 2;
		}
	}

	virtual void clear() {
		clrscr();
	}
};

class Circle : public Shape
{
protected:
	int radius;

public:
	Circle(int ax, int ay, int arad) : Shape(ax, ay) { limit = arad; }
	void circle() {
		for (double a = 0; a < 360; a ++) {
			gotoxy(int(x + sin(a * M_PI / 180) * limit), int(y - cos(a * M_PI / 180) * limit / 2));
			putch('*');
		}
	}
};

int main(void) {

	int input;
	Shape* pS = new Shape(10, 10);
	Circle* pC = new Circle(45, 25, 40);

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
			pS->draw();
			break;
		case 2:
			pC->circle();
			break;
		case 3:
			pS->square();
			break;
		case 4:
			pS->triangle();
			break;
		case 5:
			pS->triangle();
			pS->inv_triangle();
			break;
		}
	}

	delete pS;
	return 0;
}
