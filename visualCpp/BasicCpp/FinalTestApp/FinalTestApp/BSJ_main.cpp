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
	virtual void show() {
		gotoxy(x, y); putch('*');
	}
	virtual void hide() {
		gotoxy(x, y); putch(' ');
	}
};

class Circle :public Shape
{
protected:
	int radius;
public:
	Circle(int ax, int ay, int arad) : Shape(ax, ay) { radius = arad; }
	void show() {
		for (double a = 0; a < 360; a+=10)
		{
			gotoxy(int(x + sin(a * 3.14 / 180) * radius), int(y - cos(a * 3.14 / 180) * radius / 2));
			putch('*');
		}
	}
	void hide() {
		for (double a = 0; a < 360; a += 10)
		{
			gotoxy(int(x + sin(a * 3.14 / 180) * radius), int(y - cos(a * 3.14 / 180) * radius / 2));
			putch(' ');
		}
	}
};

class Rect : public Shape
{
public:
	Rect(int ax, int ay) :Shape(ax, ay) {}
	void show() {
		for (int i = 10; i < 20; i++)
		{
			for (int j = 10; j <20; j++)
			{
				gotoxy(i,j);  putch('*');
			}
			cout << endl;
		}
	}
	void hide() {
		for (int i = 10; i < 20; i++)
		{
			for (int j = 10; j < 20; j++)
			{
				gotoxy(i,j);  putch(' ');
			}
			cout << endl;
		}
	}
};

class Tri : public Shape
{
protected:
	int num = 5;
public:
	Tri(int ax, int ay) : Shape(ax, ay) {}
	void show() {
		cout << endl;
		for (int i = 0; i < num; i++)
		{
			for (int j = num - 1; j > i; j--)
			{
				putch(' ');
			}
			for (int j = 0; j < 2 * i + 1; j++)
			{
				putch('*');
			}
			cout << endl;
		}
	}
	/*void hide() {
		cout << endl;
		for (int i = 0; i < num; i++)
		{
			for (int j = num - 1; j > i; j--)
			{
				putch(' ');
			}
			for (int j = 0; j < 2 * i + 1; j++)
			{
				putch(' ');
			}
			cout << endl;
		}
	}*/
};

int main(void) {
	int input;
	Shape* pS = new Shape(5, 5);

	while (true)
	{
		gotoxy(10, 0);
		printf("출력도형 선택(0:종료, 1:점, 2:원, 3:사각형, 4:삼각형, 5:별) : ");
		cin >> input;
		pS->hide();

		switch (input)
		{
		case 0:
			exit(0);
			break;
		case 1:
		{
			Shape p(10, 10);
			p.show();
			getch();
			p.hide();
			break;
		}
		case 2:
		{
			Circle c(10, 10, 10);
			c.show();
			getch();
			c.hide();
			break;
		}
		case 3:
		{
			Rect r(10, 10);
			r.show();
			getch();
			r.hide();
			break;
		}
		case 4:
		{
			Tri t(10, 10);
			t.show();
			getch();
			t.hide();
			break;
		}
		}
	}

	delete pS;
	return 0;
}
