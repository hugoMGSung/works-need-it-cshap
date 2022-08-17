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
	virtual void draw(int x) {
		gotoxy(x, y); putch('*');
	}
	virtual void c(int y) {
		clrscr();
	}
};
class Circle : public Point
{
protected:
	
	int radius;

public:
	Circle(int ax, int ay, char ach, int arad)  { radius = arad; }
	void show() {
		for (double a = 0; a < 360; a += 10) {
			gotoxy(int(x + sin(a * 3.14 / 180)radius), int(y - cos(a * 3.14 / 180) * radius / 2));
			putch(*);
		}
	}
};
void hide() {
	for (double a = 0; a < 360; a += 10) {
		gotoxy(int(x + sin(a * 3.14 / 180) * radius), int(y - cos(a * 3.14 / 180) * radius / 2)
			putch(' ')
	}
}

int main(void) {

	int input;
	int x, y;
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
			c.draw();
			break;
		}
	}

	delete pS;
	return 0;
}