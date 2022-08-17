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
	virtual void move(int mx, int my) {
		x = mx;
		y = my;
	}
	virtual void clear() {
		clrscr();
	}
};

class Graph : public Shape
{
public:
	Graph(const int x, const int y) : Shape(x, y) { ; }
	void num1() {
		this->move(10, 10);
		this->draw();
	}
	void num2() {
		this->move(20, 20);

		int r = 6;
		
		for (double a = 0; a < 300; a += 20)
		{
			this->move(int(x + sin(a * 3.14 / 180) * r),int(y - cos(a * 3.14 / 180) * r / 2));
			this->draw();
		}
	}
	void num3() {
		for (int i = 10; i < 20; i++)
		{
			for (int j = 10; j < 20; j++)
			{
				this->move(i, j);
				this->draw();
			}
		}
	}
	void num4() {
		int k=6,l=1,m=l;
		for (int j = 0; j < 7; j++)
		{
			for(int i = 0; m>0; m--,i++)
			{
				this->move(15+k+i+1, 15+j);
				this->draw();
			}
			k--;
			l += 2;
			m = l;
		}
	}
	void num5() {

		int k = 6, l = 1, m = l;
		for (int j = 0; j < 7; j++)
		{
			for (int i = 0; m > 0; m--, i++)
			{
				this->move(15 + k + i + 1, 15 + j);
				this->draw();
			}
			k--;
			l += 2;
			m = l;
		}

		l = 0;
		for (int j = 0; j < 7; j++)
		{
			for (int i = 0+l; i<12-l+1; i++)
			{
				this->move(15 + k + i +l+2, 17 + j);
				this->draw();
			}
			l++;
			k--;
		}
	}

};

int main(void) {

	int input;
	Graph* graph = new Graph(10, 10);
	
	while (true)
	{
		gotoxy(10, 1);
		printf("출력도형 선택(0:종료, 1:점, 2:원, 3:사각형, 4:삼각형, 5:별) : ");
		cin >> input;
		graph->clear();
		
		switch (input)
		{
		case 0:
			exit(0);
			break;
		case 1:
			graph->num1();
			break;
		case 2:
			graph->num2();
			break;
		case 3:
			graph->num3();
			break;
		case 4:
			graph->num4();
			break;
		case 5:
			graph->num5();
			break;
		}
	}
	delete graph;
	return 0;
}
