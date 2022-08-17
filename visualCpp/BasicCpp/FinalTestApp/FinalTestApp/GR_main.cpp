#include <stdio.h>
#include <conio.h>
#include <math.h>
#include "cursor.h"
#include <iostream>
using namespace std;

class Shape {
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

class Point : public Shape {
public:
	Point(int sx, int sy) :Shape(sx, sy) { ; }
	virtual void draw(){ gotoxy(x, y); putch('*'); }
};


class Circle : public Shape {
protected:
	int radius;
public:
	Circle(int ax, int ay, int aradius) : Shape(ax, ay) {
		radius = aradius;
	}
	virtual void draw() {
		for (double a = 0; a < 360; a += 10) {
			gotoxy(int(x + sin(a * 3.14 / 180) * radius), int(y - cos(a * 3.14 / 180) * radius / 2));
			putch('*');
		}
	}
};

class Square : public Shape {
public:
	Square(int ax, int ay) :Shape(ax, ay) { ; }
	virtual void draw() {
		for (int i = 1; i < 8; i++) {
			gotoxy(x + i, y);
			int j = 1;
			printf("*");
			for (j = 1; j < 5; j++) {
				gotoxy(x + i, y + j);
				if (i == 1 || i == 7)
					printf("*");
				else
					printf(" ");
			}
			gotoxy(x + i, y + j);
			printf("*\n");
		}
	}
};

class Triangle : public Shape {
public:
	Triangle(int sx, int sy) :Shape(sx, sy) { ; }
	virtual void draw() {
		for (int i = 0; i < 5; i++) {
			for (int j = 4; j > i; j--) {
				//gotoxy(x + i, y + j);
				printf(" ");
			}

			for (int j = 0; j < 2 * i + 1; j++) {
				//gotoxy(x + i, y + j);
				putch('*');
			}
		}
	}
};

class Star : public Shape {
public:
	Star(int sx, int sy) : Shape(sx, sy) { ; }
	virtual void draw() {
		gotoxy(x, y);
		printf("별 입니다.\n");
	}
};

int main() {
	int input;
	Shape* pS = new Shape(10, 10);
	Point po(5, 5);
	Circle cr(20, 10, 12);
	Square sq(20, 10);
	Triangle tr(20, 10);
	Star st(20, 10);

	while (true) {
		gotoxy(10, 1);
		printf("출력도형 선택(0:종료, 1:점, 2:원, 3:사각형, 4:삼각형, 5:별) : ");
		cin >> input;
		pS->clear();

		switch (input) {
		case 0:
			exit(0);
			break;
		case 1:
			po.draw();
			break;
		case 2:
			cr.draw();
			break;
		case 3:
			sq.draw();
			break;
		case 4:
			tr.draw();
			break;
		case 5:
			st.draw();
			break;
		default:
			printf("잘못된 입력입니다.\n");
			break;
		}
	}

	delete pS;
	return 0;
}