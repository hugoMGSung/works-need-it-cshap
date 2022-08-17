#include <stdio.h>

class Shape
{
public:
	virtual void draw() { puts("���� ������Ʈ�Դϴ�."); }
};

class Line : public Shape
{
public:
	void draw() { puts("���� �߽��ϴ�."); }
};

class Circle : public Shape
{
public:
	void draw() { puts("���׶�� �׷ȴ� ġ��."); }
};

class Rect : public Shape
{
public:
	void draw() { puts("��� �簢���Դϴ�."); }
};

class Triangle : public Shape
{
public:
	void draw() { puts("���� ���� �߰��� �ﰢ���̴�."); }
};

int main()
{
	Shape* ar[] = { new Triangle(), new Rect(), new Circle() };

	for (int i = 0; i < sizeof(ar) / sizeof(ar[0]); i++) {
		ar[i]->draw();
	}
	for (int i = 0; i < sizeof(ar) / sizeof(ar[0]); i++) {
		delete ar[i];
	}
}
