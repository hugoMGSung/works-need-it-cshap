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
		gotoxy(x, y);
		putch('*');
	}
	virtual void clear() {
		gotoxy(x, y);
		putch(' ');
	}
	void move(int nx, int ny) {
		clear();
		x = nx;
		y = ny;
		draw();
	}
};
class Circle : public Shape
{
protected:
	int radius;

public:
	Circle(int ax, int ay, int arad) : Shape(ax, ay) { radius = arad; }
	void show() {
		for (double a = 0; a < 360; a += 10) {
			gotoxy(int(x + sin(a * 3.14 / 180) * radius), int(y - cos(a * 3.14 / 180) * radius / 2));
			putch('*');
		}
	}
	void hide() {
		for (double a = 0; a < 360; a += 10) {
			gotoxy(int(x + sin(a * 3.14 / 180) * radius), int(y - cos(a * 3.14 / 180) * radius / 2));
			putch(' ');
		}
	}
};



int main(void) {

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
			
			break;
		case 2:
			Shape p(1, 1, '*');
			Circle c(20, 10, '*', 12);

			p.draw();
			c.draw();

			getch();
			p.move(10, 1);
			getch();
			c.move(10, 10);
			getch();
			break;
		case 3:

			break;
		case 4:

			break;
		case 5:

			break;
		}
	}

	delete pS;
	return 0;
}