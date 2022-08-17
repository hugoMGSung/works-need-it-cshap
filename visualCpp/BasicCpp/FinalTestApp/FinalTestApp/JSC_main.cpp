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

class Line : public Shape {
public:
	Line(int ax, int ay) : Shape(ax, ay) { ; };
	void draw() {
		gotoxy(x, y); putch('*');
	};
	void clear() {
		clrscr();
	}
};

class Circle : public Shape {
public:
	Circle(int ax, int ay) : Shape(ax, ay) { ; };
	void draw() {
		gotoxy(x, y); puts("****");
		gotoxy(x - 2, y + 1); puts("**    **");
		gotoxy(x - 2, y + 2); puts("*      *");
		gotoxy(x - 2, y + 3); puts("**    **");
		gotoxy(x, y + 4); puts("****");
	};
	void clear() {
		clrscr();
	}
};

class Ren : public Shape {
public:
	Ren(int ax, int ay) : Shape(ax, ay) { ; };
	void draw() {
		gotoxy(x, y); puts("****");
		gotoxy(x, y + 1); puts("****");
		gotoxy(x, y + 2); puts("****");
		gotoxy(x, y + 3); puts("****");
		gotoxy(x, y + 4); puts("****");
	};
	void clear() {
		clrscr();
	}
};

class Tri : public Shape {
public:
	Tri(int ax, int ay) : Shape(ax, ay) { ; };
	void draw() {
		gotoxy(x, y); puts("*");
		gotoxy(x - 1, y + 1); puts("* *");
		gotoxy(x - 2, y + 2); puts("*   *");
		gotoxy(x - 3, y + 3); puts("*     *");
		gotoxy(x - 4, y + 4); puts("*********");
	};
	void clear() {
		clrscr();
	}
};

class Star : public Shape {
public:
	Star(int ax, int ay) : Shape(ax, ay) { ; };
	void draw() {
		gotoxy(x, y); puts("*");
		gotoxy(x - 2, y + 1); puts("*****");
		gotoxy(x - 1, y + 2); puts("* *");
		gotoxy(x - 2, y + 3); puts("*   *");
	};
	void clear() {
		clrscr();
	}
};



int main(void)
{
	int input;
	Shape* pS[6] = { new Shape(10, 10), new Line(10, 10) ,new Circle(10, 10),new Ren(10, 10),new Tri(10, 10), new Star(10,10) };

	while (true)
	{
		gotoxy(10, 1);
		printf("출력도형 선택(0:종료, 1:점, 2:원, 3:사각형, 4:삼각형, 5:별) : ");
		cin >> input;
		pS[0]->clear();
		pS[1]->clear();
		pS[2]->clear();
		pS[3]->clear();
		pS[4]->clear();
		pS[5]->clear();

		switch (input)
		{
		case 0:
			exit(0);
			break;
		case 1:
			pS[1]->draw();
			break;
		case 2:
			pS[2]->draw();
			break;
		case 3:
			pS[3]->draw();
			break;
		case 4:
			pS[4]->draw();
			break;
		case 5:
			pS[5]->draw();
			break;
		}
	}

	delete pS;
	return 0;
};
