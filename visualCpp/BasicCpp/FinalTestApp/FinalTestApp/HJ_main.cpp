#include <stdio.h>
#include <conio.h>
#include <math.h>
#include <iostream>
#include "cursor.h"
using namespace std;

class Shape
{
protected:
	int x, y;
public:
	Shape() { ; }
	Shape(int ax, int ay) { x = ax; y = ay; }
	virtual void draw() {
		gotoxy(x, y); putch('*');
	}
	virtual void clear() {
		clrscr();
	}
};


class Circle : public Shape
{
protected:
	int radius=5;

public:
	Circle() { ; }
	Circle(int ax, int ay) : Shape (ax, ay) { ; }
	void draw() {


		for (double a = 0; a < 360; a += 10) {
			gotoxy(int(x + sin(a * 3.14 / 180) * radius), int(y - cos(a * 3.14 / 180) * radius / 2));
			putch('*');
		}
	}
	void clear() {
		for (double a = 0; a < 360; a += 10) {
			gotoxy(int(x + sin(a * 3.14 / 180) * radius), int(y - cos(a * 3.14 / 180) * radius / 2));
			putch(' ');
		}
	}
};

class Rect : public Shape
{
protected:
	int radius = 5;

public:
	Rect() { ; }
	Rect(int ax, int ay) : Shape(ax, ay) { ; }
	void draw() {
		for (double a = 5; a <= 15; a ++) {
			gotoxy(5,a);
			putch('*');
			gotoxy(15, a);
			putch('*');
			gotoxy(a, 5);
			putch('*');
			gotoxy(a, 15);
			putch('*');
		}
	}
	void clear() {
		for (double a = 5; a <= 15; a ++) {
			gotoxy(5, a);
			putch(' ');
			gotoxy(15, a);
			putch(' ');
			gotoxy(a, 5);
			putch(' ');
			gotoxy(a, 15);
			putch(' ');
		}
	}
};

class Tri : public Shape
{
protected:
	int radius = 5;

public:
	Tri() { ; }
	Tri(int ax, int ay) : Shape(ax, ay) { ; }
	
	void draw() {
		for (int i = 0; i <= 5; i++)
		{
			gotoxy(10, 10 + i);
			putch('*');
			gotoxy(10 + i, 10);
			putch('*');
			gotoxy(15 - i, 10+i);
			putch('*');
			
		}

	}
	void clear() {
		for (int i = 0; i <= 5; i++)
		{
			gotoxy(10, 10 + i);
			putch(' ');
			gotoxy(10 + i, 10);
			putch(' ');
			gotoxy(15 - i, 10 + i);
			putch(' ');
		}
	}

};


int main(void) {

	int input;
	Shape* pS[] = {new Shape(10,10), new Circle(10,10), new Rect(10,10), new Tri(10,10)};
	

	while (true)
	{
		gotoxy(10, 1);
		printf("출력도형 선택(0:종료, 1:점, 2:원, 3:사각형, 4:삼각형) : ");
		cin >> input;

		for (int i = 0; i < 4; i++)
		{
			pS[i]->clear();
		}
		
		switch (input)
		{
		case 0:
			exit(0);
			break;
		case 1:
			pS[0]->draw();
			break;
		case 2:
			pS[1]->draw();
			break;
		case 3:
			pS[2]->draw();
			break;
		case 4:
			pS[3]->draw();
			break;
		}
	}

	delete []pS;
	return 0;
}
