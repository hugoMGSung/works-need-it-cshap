#include <stdio.h>
#include <conio.h>
#include <math.h>
#include <iostream>
#include "cursor.h"

using namespace std;
// 점, 원, 사각형, 삼각형, 별(옵션) 등을 출력하는 프로그램을 완성하시오
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

class Circle :public Shape // 원
{
protected:
	int radius;

public:
	Circle(int ax, int ay, int arad) : Shape(ax, ay) { radius = arad; }
	void draw() {
		for (double a = 0; a < 360; a += 10) {
			gotoxy(int(x + sin(a * 3.14 / 180) * radius), int(y - cos(a * 3.14 / 180) * radius / 2));
			putch('*');
		}
	}
};

class Rect :public Shape // 사각형
{
public:
	Rect(int ax, int ay) : Shape(ax, ay) {  }
	void draw() {
		for (int i = 0; i < 5; i++)
		{
			gotoxy(10, (2 * i) + 5);
			if (i == 0 || i == 4)
			{
				for (int j = 0; j < 8; j++)
				{
					printf("* ");
				}
			}
			else
			{
				printf("* ");
				for (int j = 0; j < 12; j++)
				{
					printf(" ");
				}
				printf("*");
			}
		}
	}

};

class Triangle :public Shape // 삼각형
{
public:
	Triangle(int ax, int ay) : Shape(ax, ay) {  }
	void draw() {
		for (int i = 0; i < 5; i++)
        {
               gotoxy(20 - 2 * i, 3 + 2 * i);
               for (int j = 0; j < 2 * (i + 1) - 1; j++)
               {
                       printf("* ");
               }
        }
        printf("\n");
	}

};

class star :public Shape // 별
{
public:
	star(int ax, int ay) : Shape(ax, ay) {  }
	void draw() {
		putch('*');
	}

};

int main(void) {

	int input;
	Shape* pS = new Shape(10, 10);
	Circle c(20, 10, 12);
	Rect r(20, 10);
	Triangle t(20, 10);

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
		case 1: // 점
			pS->draw();
			break;
		case 2: // 원
			c.draw();
			break;
		case 3: // 사각형
			r.draw();
			break;
		case 4: // 삼각형
			t.draw();
			break;
		case 5:

			break;
		}
	}

	delete pS;
	return 0;
}
