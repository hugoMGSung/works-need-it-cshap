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

class Point : Shape {
public:
	Point(int ax, int ay) : Shape(ax, ay) { ; }
	void draw() {
		gotoxy(x, y); putch('*');
	}
};

class Circle : Shape {
private:
	int radius;
public:
	Circle(int ax, int ay, int aradius) : Shape(ax, ay) ,radius(aradius) { ; }
	void draw() {
		for (double a = 0; a < 360; a += 10) {
			gotoxy(int(x + sin(a * 3.14 / 180) * radius), int(y - cos(a * 3.14 / 180) * radius / 2));
			putch('*');
		}
	}
};

class Rect : Shape {
private:
	int size;
public:
	Rect(int ax, int ay, int asize) : Shape(ax, ay) , size(asize) { ; }
	void draw() {
		
		for (int i = 0; i < size; i++) {
			gotoxy(x, y + i);
			for (int j = 0; j < size; j++) {
				putchar('*');
			}
			putchar('\n');
		}
	}
};

class Triangle : Shape {
private:
	int size;
public:
	Triangle(int ax, int ay, int asize) : Shape(ax, ay), size(asize) { ; }
	void draw() {
		for (int i = 0; i < size; i++) {
			gotoxy(x, y + i);
			for (int j = 0; j < i; j++) {
				putchar('*');
			}
			putchar('\n');
		}
	}
};

class Star : Shape {
private:
public:
	Star(int ax, int ay) :Shape(ax, ay) { ; }
	void draw() {
		
	}
};

int main(void) {
	int input;
	Shape* pS = new Shape(10, 10);
	
	Point p(30, 10);
	Circle c(30, 10, 10);
	Rect r(30, 10, 20);
	Triangle t(30, 10, 20);
	Star s(30, 20);
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
			r.draw();
			break;
		case 4:
			t.draw();
			break;
		case 5:
			s.draw();
			break;
		}
	}
	delete pS;
	return 0;
}