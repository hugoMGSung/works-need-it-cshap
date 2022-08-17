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

class Point:public Shape
{
public:
	Point(int ax, int ay) :Shape(ax, ay) { ; }
	void draw() {
		gotoxy(x, y); puts(".");
	}
};

class Circle:public Shape
{
protected:
	int radius;
public:
	Circle(int ax, int ay, int arad) :Shape(ax, ay) { radius = arad; }
	void draw() {
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


class Rect :public Shape
{
protected:
	int w, h;
public:
	Rect(int ax, int ay, int aw, int ah) :Shape(ax, ay) { w = aw, h = ah; }
	void draw() {
		for(int i = 0 ; i < x ;++i)
		{
			
			for (int j = 0; j < y; ++j) {
				cout << '*';
			}
			cout << endl;
		}
	}
};

class Triangle :public Shape
{
protected:
	int h;
public:
	Triangle(int ax, int ay, int ah) :Shape(ax, ay) { h = ah; }
	void draw() {
		for (int i = 1; i <= h; i++)
		{
			for (int w = 1; w<= h-i;w++) {
				putch(' ');
			}
			for (int j = 1; j <= i*2-1;j++)
			{
				putch('*');
			}
			cout << endl;
		}
	}
};
int main(void) {

	int input;
	Shape* pS = new Shape(10, 10);
	Point p(10, 10);
	Circle c(10, 10, 10);
	Rect R(10, 10, 10, 10);
	Triangle T(10, 10, 5);

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
			p.draw();
			break;
		case 2:
			c.draw();
			break;
		case 3:
			R.draw();
			break;
		case 4:
			T.draw();
			break;
		}
	}

	delete pS;
	return 0;
}
