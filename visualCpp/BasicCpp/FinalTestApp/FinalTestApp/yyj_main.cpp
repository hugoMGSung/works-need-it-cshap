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

class Dot :public Shape
{
public:
	Dot(int dx, int dy) :Shape(dx, dy) { ; }
	virtual void draw() { gotoxy(x, y); putch('*'); }
};

class Circle :public Shape
{
protected:
	int r;
public:
	Circle(int ax, int ay, int ar) :Shape(ax, ay)
	{
		r = ar;
	}
	virtual void draw()
	{
		for (double a = 0; a < 360; a += 10) 
		{
			gotoxy(int(x + sin(a * 3.14 / 180) * r), int(y - cos(a * 3.14 / 180) * r / 2));
			putch('*');
		}
	}
};

class Rect:public Shape
{
private:
	int co;
public:
	Rect(int ax, int ay,int aco) :Shape(ax, ay),co(aco) { ; }
	virtual void draw()
	{
		for (int a = 0; a < co; a++)
		{
			for (int b = 0; b < co; b++)
			{
				gotoxy(x + a, y + b);
				putch('*');
			}
		}
	}
};

class Triangle :public Shape
{
private:
	int num;
public:
	Triangle(int ax, int ay, int anum) :Shape(ax, ay), num(anum) { ; }
	virtual void draw()
	{
		for (int a = 0; a < num; a++)
		{
			printf(" ");
			for (int b = 0; b < a * 2 + 1; b++)
			{
				gotoxy(x + a, y + b);
				putch('*');
			}
		}
	}
};


int main() {
	int input;
	Shape* pS = new Shape(10, 10);
	Dot dt(5, 5);
	Circle cr(20, 10, 12);
	Rect rc(5, 5, 5);
	Triangle ta(10, 10, 10);

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
			dt.draw();
			break;
		case 2:
			cr.draw();
			break;
		case 3:
			rc.draw();
			break;
		case 4:
			ta.draw();
			break;
	
		}
	}

	delete pS;
	return 0;
}