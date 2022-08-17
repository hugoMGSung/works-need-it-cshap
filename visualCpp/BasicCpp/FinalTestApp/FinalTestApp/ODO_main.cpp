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

class Circle : public Shape
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

};

class Square : public Shape
{
protected:
	int length;

public:
	Square(int ax, int ay, int alen) :Shape(ax, ay) { length = alen; }
	void draw() {
		gotoxy(x, y - 2);
		cout << "�簢��, ���� ���̴� " << length << endl;		// �ӽ� ���
		for (int i = 0; i < length; i++)
		{
			if (i % (length - 1) == 0)
			{
				for (int j = 0; j < length; j++)
				{
					gotoxy(x + j, y + i);
					putch('*');
				}
			}
			else
			{
				gotoxy(x, y + i);
				putch('*');
				gotoxy(x + (length - 1), y + i);
				putch('*');
			}
		}

	}

};

class Triangle : public Shape
{
protected:
	int length;

public:
	Triangle(int ax, int ay, int alen) : Shape(ax, ay) { length = alen; }
	void draw() {
		gotoxy(x, y - 2);
		cout << "�ﰢ��, ���� ���̴� " << length << " || �ﰢ��, ���̴� " << length * sqrt(3) / 2 << endl;		// �ӽ� ���
		/* ���� ���� ��ġ�� ��� */
		for (int i = 0; i < length; i++)
		{
			gotoxy(x + i, y + length - 1);
			putch('*');
		}
		gotoxy(x + (length / 2), y);
		putch('H');
	}
};

class Star : public Shape
{
protected:
	int length;

public:
	Star(int ax, int ay, int alen) : Shape(ax, ay) { length = alen; }
	void draw() {
		gotoxy(x, y - 2);
		cout << "��, �� ���� ���̴� " << length << endl;		// �ӽ� ���
	}
};

int main(void) {

	int input;
	Shape* pS[5];

	pS[0] = new Shape(10, 10);
	pS[1] = new Circle(10, 10, 5);
	pS[2] = new Square(10, 10, 5);
	pS[3] = new Triangle(10, 10, 10);
	pS[4] = new Star(10, 10, 3);

	while (true)
	{
		gotoxy(10, 1);
		printf("��µ��� ����(0:����, 1:��, 2:��, 3:�簢��, 4:�ﰢ��, 5:��) : ");
		cin >> input;
		pS[0]->clear();

		switch (input)
		{
		case 0:
			/* �����Ҵ� ���� */
			for (int i = 0; i < 5; i++)
			{
				delete pS[i];
			}
			exit(0);
			break;
		case 1:
			pS[0]->draw();		// �� ���
			break;
		case 2:
			pS[1]->draw();		// �� ���
			break;
		case 3:
			pS[2]->draw();		// �簢�� ���
			break;
		case 4:
			pS[3]->draw();		// �ﰢ�� ���
			break;
		case 5:
			pS[4]->draw();		// �� ���
			break;
		}
	}
	return 0;
}