#include <stdio.h>
#include <conio.h>
#include <math.h>
#include "cursor.h"
#include <iostream>
#include <Windows.h>
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

class Dot : public Shape
{
public:
	Dot(int ax,int ay) : Shape(ax,ay){}
	virtual void draw() {
		gotoxy(x, y); putch('.');
	}
	virtual void clear() {
		clrscr();
	}
};

class Circle : public Shape
{
private:
	int radius;
public:
	Circle(int ax, int ay, int arad) : Shape(ax, ay) { radius = arad; }
	virtual void draw() {
		for (double a = 0; a < 360; a += 10) {
			gotoxy(int(x + sin(a * 3.14 / 180) * radius), int(y - cos(a * 3.14 / 180) * radius / 2));
			putch('*');
		}
	}
	virtual void clear() {
		clrscr();
	}
};
class triangle : public Shape
{
public:
	triangle(int ax, int ay) : Shape(ax, ay) {}
	virtual void draw() {
		gotoxy(x, y);
		putch('*');
		gotoxy(x - 1, y + 1);
		puts("* *");
		gotoxy(x - 2, y + 2);
		puts("*****");
	}
	virtual void clear() {
		clrscr();
	}
};
class Square : public Shape
{
public:
	Square(int ax, int ay) : Shape(ax, ay) {}
	virtual void draw() {
		gotoxy(x, y);
		int delta = 1;
		for (int j = 0; j < 2; j++) {
			for (int i = 0; i < 10; i++)
			{
				gotoxy(x +=delta, y);
				putch('*');
			}

			delta = -delta;
			for (int i = 0; i < 10; i++)
			{
				gotoxy(x, y -= delta);
				putch('*');
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
	Star(int ax, int ay) : Shape(ax, ay) {}
	virtual void draw() {
		gotoxy(x, y);
		for (int i = 1; i <= 3; i++)
		{
			for (int j = 7; j > i; j--)
			{
				putch(' ');
			}
			for (int k = 1; k < i * 2; k++)
			{
				putch('*');
			}
			cout << endl;
			gotoxy(x, y+=1);

		}
		for (int h = 0; h <= 12; h++)
		{
			putch('*');
		}
		cout << endl;
		gotoxy(x, y += 1);

		for (int j = 0; j < 2; j++)
		{
			for (int i = 0; i <= j; i++)
			{
				putch(' ');
			}
			for (int k = 10; k >= j * 2; k--)
			{
				putch('*');
			}
			cout << endl;
			gotoxy(x, y += 1);
		}
		for (int i = 1; i <= 2; i++)
		{
			for (int j = 2; j > i; j--)
			{
				putch(' ');
			}
			for (int k = 0; k <= (i + 8) + i; k++)
			{
				putch('*');
			}
			cout << endl;
			gotoxy(x, y += 1);
		}

		for (int i = 1; i <= 3; i++)
		{
			putch('  ');
			for (int j = 0; j <= i; j++)
			{
				putch(' ');
			}
			for (int k = 7; k > i * 2; k--)
			{
				putch('*');
			}
			cout << endl;
			gotoxy(x, y += 1);
		}

	}
	virtual void clear() {
		clrscr();
	}
};
int main() {

	int input;
	Shape* pS = new Shape(10, 10);
	Dot* pD = new Dot(10, 10);
	Circle* pC = new Circle(10, 10,10);
	triangle* pT = new triangle(10, 10);
	Square* pSq = new Square(10, 10);
	Star* pSt = new Star(10, 10);

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
			pD->draw();
			break;
		case 2:
			pC->draw();
			break;
		case 3:
			pT->draw();
			break;
		case 4:
			pSq->draw();
			break;
		case 5:
			pSt->draw();
			break;

		}
	}

	delete pS;
	delete pD;
	delete pC;
	delete pT;
	delete pSq;
	delete pSt;

	return 0;
}
