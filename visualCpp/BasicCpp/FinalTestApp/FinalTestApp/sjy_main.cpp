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
	void right() { x++; }
	void left() { x--; }
	void down() { y++; }
	void up() { y--; }
public:
	Shape(int ax, int ay) { x = ax; y = ay; }
	virtual void draw() {
		gotoxy(x, y); putch('*');
	}
	virtual void clear() {
		clrscr();
		x = 10, y = 10;
	}

	void circle() {
		draw();
		right();
		draw();
		right();
		draw();
		down();
		right();
		draw();
		left();
		draw();
		left();
		draw();
		left();
		draw();
		left();
		draw();
		down();
		draw();
		right();
		draw();
		right();
		draw();
		right();
		draw();
		right();
		draw();
		down();
		left();
		draw();
		left();
		draw();
		left();
		draw();
	}
	void square() {
		draw();
		right();
		draw();
		right();
		draw();
		down();
		draw();
		down();
		draw();
		left();
		draw();
		left();
		draw();
		up();
		draw();
	}
	void tri() {
		draw();
		right();
		down();
		draw();
		left();
		left();
		draw();
	}
	void star() {
		draw();
		down();
		left();
		draw();
		right();
		draw();
		right();
		draw();
		down();
		right();
		right();
		right();
		draw();
		left();
		draw();
		left();
		draw();
		left();
		draw();
		left();
		draw();
		left();
		draw();
		left();
		draw();
		left();
		draw();
		left();
		draw();
		down();
		right();
		draw();
		right();
		draw();
		right();
		draw();
		right();
		draw();
		right();
		draw();
		right();
		draw();
		right();
		draw();
		down();
		draw();
		left();
		draw();
		left();
		draw();
		left();
		draw();
		left();
		draw();
		left();
		draw();
		left();
		draw();
		down();
		left();
		draw();
		right();
		draw();
		right();
		draw();
		right();
		draw();
		right();
		draw();
		right();
		draw();
		right();
		draw();
		right();
		draw();
		right();
		draw();
		down();
		left();
		left();
		left();
		draw();
		left();
		draw();
		left();
		draw();
		down();
		right();
		draw();
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
			pS->draw();
			break;
		case 2:
			pS->circle();
			break;
		case 3:
			pS->square();
			break;
		case 4:
			pS->tri();
			break;
		case 5:
			pS->star();
			break;
		}
	}

	delete pS;
	return 0;
}
