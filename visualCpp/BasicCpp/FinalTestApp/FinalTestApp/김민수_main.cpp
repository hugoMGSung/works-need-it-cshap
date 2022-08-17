#include <stdio.h>
#include <conio.h>
#include <math.h>
#include <iostream>
#include "cursor.h"
#include <Windows.h>
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

class Circle : public Shape
{
protected:
    int radius;

public:
    Circle(int ax, int ay, int arad) : Shape(ax, ay) { radius = arad; }
    void draw()
    {
        for (double a = 0; a < 360; a+=10)
        {
            gotoxy(int(x + sin(a * 3.14 / 180) * radius), int(y - cos(a * 3.14 / 180) * radius / 2));
            putch('*');
        }
    }
};

class Square : public Shape
{
protected:
    int width;
    int height;

public:
    Square(int ax, int ay, int awid, int ahei) : Shape(ax, ay) { width = awid, height = ahei; }
    void draw()
    {
        for (double a = 0; a < 80; a++)
        {
            //gotoxy(int ();
            putch('*');
        }
    }        

}; 


int main(void) {

    int input;
    Shape* pS = new Shape(10, 10);
    Circle c(20, 10, 12);
    Square s(20, 20, 20, 20);

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
            
            break;
        case 2:
            c.draw();
            break;
        case 3:
            s.clear();
            break;
        case 4:

            break;
        case 5:
            break;
        }
    }
    
    delete pS;
    return 0;
}