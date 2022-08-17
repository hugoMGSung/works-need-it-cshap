#include <stdio.h>
#include <conio.h>
#include <math.h>
#include <iostream>
#include "cursor.h"

using namespace std;
// ��, ��, �簢��, �ﰢ��, ��(�ɼ�) ���� ����ϴ� ���α׷��� �ϼ��Ͻÿ�
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

class Circle :public Shape // ��
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

class Rect :public Shape // �簢��
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

class Triangle :public Shape // �ﰢ��
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

class star :public Shape // ��
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

		printf("��µ��� ����(0:����, 1:��, 2:��, 3:�簢��, 4:�ﰢ��, 5:��) : ");
		cin >> input;
		pS->clear();

		switch (input)
		{
		case 0:
			exit(0);
			break;
		case 1: // ��
			pS->draw();
			break;
		case 2: // ��
			c.draw();
			break;
		case 3: // �簢��
			r.draw();
			break;
		case 4: // �ﰢ��
			t.draw();
			break;
		case 5:

			break;
		}
	}

	delete pS;
	return 0;
}
