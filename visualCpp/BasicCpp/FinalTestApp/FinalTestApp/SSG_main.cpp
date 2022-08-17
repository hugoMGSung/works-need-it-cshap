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

class Dot :public Shape
{
public:
	Dot(int ax, int ay):Shape(ax, ay) {;}
	void draw() {
		gotoxy(x, y); putch('*');
	}
};

class Circle : public Shape
{
private:
	int radius = 10;

public:
	Circle(int ax, int ay) : Shape(ax, ay) { ; }
	void draw() {
		for (double a = 0; a < 360; a += 10) {
			gotoxy(int(x + sin(a * 3.14 / 180) * radius), int(y - cos(a * 3.14 / 180) * radius / 2));
			putch('*');
		}
	}
	
};
class Rec : public Shape
{
public:
	Rec(int ax, int ay) :Shape(ax, ay) { ; }
	void draw() {
		for (int i = 0; i < 10; i++) {
			gotoxy(x, y+i);
			for (int i = 0; i < 20; i++)cout << '*';
		}
	}
};

class Tri : public Shape
{
public:
	Tri(int ax, int ay) :Shape(ax, ay) { ; }
	void draw() {
		int n=13;
		for (int i = 0; i < (n / 2) + 1; i++) 
		{
			gotoxy(x, y + i);
				for (int j = 0; j < (n / 2) - i; j++)
					printf(" ");
				for (int k = 0; k < (2 * i) + 1; k++)
					printf("*");
				printf("\n");
			}
		}
};

class Star : public Shape
{
public:
	Star(int ax, int ay) :Shape(ax, ay) { ; }
	void draw() {
		char arr[13][13] = { {} };
		int x, y;
		for (x = 0; x < 13; x++)
			for (y = 0; y < 13; y++)
			{
				arr[x][y] = ' ';
			}
		for (x = 0; x < 13; x++)
			for (y = 0; y < 13; y++)
			{
				if ((y >= 6 - x && y <= x + 6 && 0 <= x && x <= 6)
					|| (y > x - 3 && x < 15 - y && x <= 8 && x >= 2))
					arr[x][y] = '*';
			}
		for (int i = 0; i < 13; i++)
		{
			gotoxy(x, y + i);
			for (int j = 0; j < 13; j++)
			{
				cout << arr[i][j];
			}
			cout<<endl;
		}
	}
};


int main(void) {

	int input;
	Shape* pS = new Shape(10, 10);
	Dot a(20, 20);
	Circle b(20, 20);
	Rec c(20, 15);
	Tri d(20, 15);
	Star e(25, 20);
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
			gotoxy(10, 4);
			cout << "점을 출력합니다." << endl;

			pS = &a;
			pS->draw();
			break;
		case 2:
			gotoxy(10, 4);
			cout << "원을 출력합니다." << endl;

			pS = &b;
			pS->draw();

			break;
		case 3:
			gotoxy(10, 4);
			cout << "사각형을 출력합니다." << endl;

			pS = &c;
			pS->draw();
			break;
		case 4:
			gotoxy(10, 4);
			cout << "삼각형을 출력합니다." << endl;

			pS = &d;
			pS->draw();
			break;

		case 5:
			gotoxy(10, 4);
			cout << "별을 출력합니다." << endl;

			pS = &e;
			pS->draw();
			break;

		default:
			gotoxy(10, 4);
			cout << "0~5중에 선택하세요";
			break;
		}
	}

	delete pS;
	return 0;
}
