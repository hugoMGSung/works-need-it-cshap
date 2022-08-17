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

private:

};

class Center
{
public:
	Center(int ax, int ay, char ach) : x(ax), y(ay), ch(ach) { ; }

	int GetX() const { return x; }
	int GetY() const { return y; }

private:
	const int x, y;
	const char ch;
};

class Circle
{
public:
	Circle(int ar, char ach, Center* apCenter) : r(ar), ch(ach), pCenter(apCenter) { ; }

	void Revolve(double angle)
	{
		x = int(cos(angle * 3.1416 / 180) * r * 2);
		y = int(sin(angle * 3.1416 / 180) * r);
		Show();
	}
	void Show()
	{
		gotoxy(pCenter->GetX() + x, pCenter->GetY() + y); putch(ch);
	}

private:
	int r;
	int x, y;
	const char ch;
	const Center* pCenter;
};


int main(void) {
	Center C(30, 10, ' ');
	Circle R(10, '*', &C);
	int input;
	Shape* pS = new Shape(10, 10);
	Point p(10, 10);

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
			for (double angle = 0; !kbhit(); angle += 5)
			{
				R.Revolve(angle);
				delay(100);
			}
			break;
		}
	}

	delete pS;
	return 0;
}
