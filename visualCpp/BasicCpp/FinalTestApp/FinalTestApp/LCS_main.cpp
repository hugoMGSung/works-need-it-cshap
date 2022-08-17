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
public:
	Point(int ax, int ay) : Shape(ax, ay) { ; }
	virtual void draw() {
		gotoxy(x, y); putch('*');
	}
	virtual void clear() {
		clrscr();
	}
};

class Circle : public Shape
{
private:
	int r;
public:
	Circle(int ax, int ay, int ar = 5) : Shape(ax, ay), r(ar) { ; }
	virtual void draw() {
		for (double a = 0; a < 360; a+=10)
		{
			gotoxy(int(x + sin(a * 3.14 / 180) * r), int(y - cos(a * 3.14 / 180) * r / 2));
			putch('*');
		}
	}
	virtual void clear() {
		clrscr();
	}
};

class Quadrangle : public Shape
{
private:
	int r;
public:
	Quadrangle(int ax, int ay, int ar = 10) : Shape(ax, ay), r(ar) { ; }
	virtual void draw() {
		for (int i = 0; i < r; i++)
		{
			if (i == 0 || i == r - 1)
			{
				for (int j = 0; j < r; j++)
				{
					gotoxy(x + i, y + j);
					putch('*');
				}
			}
			else
			{
				gotoxy(x + i, y);
				putch('*');
				gotoxy(x + i, y + r - 1);
				putch('*');
			}
		}
	}
	virtual void clear() {
		clrscr();
	}
};

class Triangle : public Shape
{
private:
	int r;
public:
	Triangle(int ax, int ay, int ar = 7) : Shape(ax, ay), r(ar) { ; }
	virtual void draw() {
		for (int i = 0; i < r; i++)
		{
			if (i == 0)
			{
				gotoxy(x + r, y + i);
				putch('*');
			}
			else if (i > 0 && i < r - 1)
			{
				gotoxy(x + r - i, y + i);
				putch('*');
				gotoxy(x + r + i, y + i);
				putch('*');
			}
			else
			{
				gotoxy(x + 1, y + i);
				for (int j = 0; j < r * 2 - 1; j++)
				{
					putch('*');
				}
			}
		}
	}
	virtual void clear() {
		clrscr();
	}
};

class Star : public Shape
{
public:
	Star(int ax, int ay) : Shape(ax, ay) { ; }
	virtual void draw() {
		for (int i = 0; i < 25; i++)
		{
			gotoxy(50 + i, 15);
			putch('*');
		}

		for (int i = 0; i < 15; i++)
		{
			gotoxy(74 - i * 1.5, 16 + i);
			putch('*');
		}

		for (int i = 0; i < 22; i++)
		{
			gotoxy(51 + i * 0.5, 30 - i);
			putch('*');
		}

		for (int i = 0; i < 22; i++)
		{
			gotoxy(62 + i * 0.5, 10 + i);
			putch('*');
		}

		for (int i = 0; i < 15; i++)
		{
			gotoxy(71 - i * 1.5, 29 - i);
			putch('*');
		}
	}
	virtual void clear() {
		clrscr();
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
			pS = new Point(10, 10);
			pS->draw();
			break;
		case 2:
			pS = new Circle(10, 10);
			pS->draw();
			break;
		case 3:
			pS = new Quadrangle(10, 10);
			pS->draw();
			break;
		case 4:
			pS = new Triangle(10, 10);
			pS->draw();
			break;
		case 5:
			pS = new Star(10, 10);
			pS->draw();
			break;
		}
	}

	delete pS;
	return 0;
}

