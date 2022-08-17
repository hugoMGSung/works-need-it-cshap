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

class Point : public Shape
{
protected:
public:
	Point(int ax, int ay) : Shape(ax, ay) { }
	virtual void draw() {
		gotoxy(x, y); putch('*');
	}
	void clear() {
		clrscr();
	}
};

class Circle : public Shape
{
protected:
	int radius;

public:
	Circle(int ax, int ay, int arad) : Shape(ax, ay) { radius = arad; }
	virtual void draw() {
		for (double a = 0; a < 360; a += 10) {
			gotoxy(int(x + sin(a * 3.14 / 180) * radius), int(y - cos(a * 3.14 / 180) * radius / 2));
			putch('*');
		}
	}
	void clear() {
		clrscr();
	}
};

int main(void) {

	int input;
	Shape* pS = new Shape(10, 10);

	while (true)
	{
		gotoxy(10, 1);
		printf("��µ��� ����(0:����, 1:��, 2:��, 3:�簢��, 4:�ﰢ��, 5:��) : ");
		cin >> input;
		pS->clear();

		switch (input)
		{
		case 0:
			exit(0);
			break;
		case 1:
		{
			Point p(10, 10);
			pS = &p;
			pS->draw();
		}
		break;
		case 2:
		{
			Circle c(20, 20, 5);
			pS = &c;
			pS->draw();
		}
		break;
		default:
			break;
		}
	}
	
	delete pS;
	return 0;
}