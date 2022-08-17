#include <stdio.h>
#include <conio.h>
#include <math.h>
#include "cursor.h"
#include <iostream>
using namespace std;

class Shape {
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

class Point : public Shape {
public:
    Point(int sx, int sy) :Shape(sx, sy) { ; }
    virtual void draw() { gotoxy(x, y); putch('*'); }
};


class Circle : public Shape {
protected:
    int radius;
public:
    Circle(int ax, int ay, int aradius) : Shape(ax, ay) {
        radius = aradius;
    }
    virtual void draw() {
        for (double a = 0; a < 360; a += 10) {
            gotoxy(int(x + sin(a * 3.14 / 180) * radius), int(y - cos(a * 3.14 / 180) * radius / 2));
            putch('*');
        }
    }
};

class Rect : public Shape
{
private:
    int ch;
public:
    Rect(int ax, int ay, int ach) : Shape(ax, ay),ch(ach) {
    }
    virtual void draw() {
        for (int a = 0; a < ch; a++) {
            for (int b = 0; b < ch; b++) {
                gotoxy(x+a,y+b);
                putch('*');
            }
        }
    }
};

class Triangle : public Shape
{
private:
    int ch;
public:
    Triangle(int ax, int ay, int ach) : Shape(ax, ay), ch(ach) {
    }
    virtual void draw() {
        int i, j;
        for (i = 0; i < ch; i++) {
            for (j = ch - 1; j > i; j--) {
                printf(" ");
            }

            for (j = 0; j < 2 * i + 1; j++) {
                printf("*");
            }
            gotoxy(x + i, y + j);
            printf("\n");
            
        }
    }
};

int main() {
    int input;
    Shape* pS = new Shape(10, 10);
    Point p(3, 3);
    Circle c(20, 10, 12);
    Rect r(20,10,10);
    Triangle t(5,5,5);

    while (true) {
        gotoxy(10, 1);
        printf("출력도형 선택(0:종료, 1:점, 2:원, 3:사각형, 4:삼각형, 5:별) : ");
        cin >> input;
        pS->clear();

        switch (input) {
        case 0:
            exit(0);
            break;
        case 1:
            p.draw();
            break;
        case 2:
            c.draw();
            break;
        case 3:
            r.draw();
            break;
        case 4:
            t.draw();
            break;
        case 5:
            break;
        default:
            printf("잘못된 입력입니다.\n");
            break;
        }
    }

    delete pS;
    return 0;
}