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
//��
class dot : public Shape {
public:
	dot(int ax, int ay) : Shape(ax, ay) { ; }
	virtual void draw() {
		puts("�� �Դϴ�.");
		puts("");
		gotoxy(x, y);
		cout << "....." << endl;
	}
};
//��
class star : public Shape {
public:
	star(int ax, int ay) : Shape(ax, ay) { ; }
	virtual void draw() {
		int j;
		int cnt = 0;

		puts("�� �Դϴ�.");
		puts("");

		gotoxy(x, y);
		for (int i = 0; i < 3; i++) {
			cnt = 0;
			for (j = 0; j < 10 + i; j++) {
				
				if (j < 9 - i) cout << " ";
				
				else cout << "*";
			}
			y++;
			cout << endl;
			gotoxy(x , y);
		}
		
		for (int i = 0; i < 4; i++) {
			for (j = 0; j < 19 - i; j++) {
				if (j < i) cout << " ";
				else cout << "*";
			}
			y++;
			cout << endl;
			gotoxy(x , y);
		}
		
		for (int i = 3; i > 0; i--) {
			for (j = 0; j < 19 - i + 1; j++) {
				if (j < i - 1) cout << " ";
				else cout << "*";
			}
			y++;
			cout << endl;
			gotoxy(x , y);
		}
		for (int i = 2; i >= 0; i--) {
			for (j = 0; j < 10+i; j++) {
				if (j < 9-i) cout << " ";
				else cout << "*";
			}
			y++;
			cout << endl;
			gotoxy(x, y);
			
		}
		
	}
};
//��
class circle : public Shape {
private:
	int radius;
public:
	circle(int ax, int ay, int arad) : Shape(ax, ay) { radius = arad; }
	void draw() {
		puts("�� �Դϴ�.");
		puts("");

		for (double a = 0; a < 360; a += 10) {
			gotoxy(int(x + sin(a * 3.14 / 180) * radius), int(y - cos(a * 3.14 / 180) * radius / 2));
			putch('C');
		}
	}
};
//�簢��
class rec : public Shape {
public:
	rec(int ax, int ay) : Shape(ax, ay) { ; }
	virtual void draw() {
		puts("�簢�� �Դϴ�.");
		puts("");
		gotoxy(x, y);
		for (int i = 0; i < 10; i++) {
			for (int j = 0; j < 10; j++) {
				cout << ".";
			}
			cout << endl;
			y++;
			gotoxy(x, y);
		}
	}
};
//�ﰢ��
class tri : public Shape {
public:
	tri(int ax, int ay) : Shape(ax, ay) { ; }
	virtual void draw() {
		puts("�ﰢ�� �Դϴ�.");
		puts("");

		gotoxy(x, y);
		for (int i = 0; i < 9; i++) {
			for (int j = 0; j < 9 - i - 1; j++) cout << " ";
			for (int j = 0; j < i * 2 + 1; j++) cout << ".";
			cout << endl;
			y++;
			gotoxy(x, y);
		}
	}
};

int main(void) {

	int input;

	Shape* pS = nullptr;// { new Shape(10, 10), new dot(10, 10), new circle(10, 10, 5), new rec(10, 10), new tri(10, 10), new star(10, 10) };


	while (true)
	{
		gotoxy(10, 1);
		printf("��µ��� ����(0:����, 1:��, 2:��, 3:�簢��, 4:�ﰢ��, 5:��) : ");
		cin >> input;
		//pS[0]->clear();

		switch (input)
		{
		case 0:
			exit(0);
			break;
		case 1:
			pS = new dot(10, 10);
			pS->clear();
			pS->draw();
			break;
		case 2:
			pS = new circle(10, 10, 5);
			pS->clear();
			pS->draw();
			break;
		case 3:
			pS = new rec(10, 10);
			pS->clear();
			pS->draw();
			break;
		case 4:
			pS = new tri(10, 10);
			pS->clear();
			pS->draw();
			break;
		case 5:
			pS = new star(10, 10);
			pS->clear();
			pS->draw();
			break;
		default:
			cout << "1~5���� �����ϼ���. (���� : 0)" << endl;
			break;
		}
	}

	delete pS;
	return 0;
}
