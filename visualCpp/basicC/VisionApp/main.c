/*
  filename - main.c
  version - 1.0
  description - �⺻ ���� �Լ�, structure ��ȯ�� �н�
  --------------------------------------------------------------------------------
  first created - 2020.02.07.
  writer - Hugo MG Sung.
*/

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

struct vision {
    double left;
    double right;
} global_vision = { 1.0, 2.0 };

struct vision exchange(struct vision robot);
int main(void) {    
    struct vision robot;
    global_vision.left = 10.5;
    printf("�÷� �Է�:");
    scanf("%lf%lf", &(robot.left), &(robot.right));
    printf("ó���÷� %.1lf, %.1lf\n", robot.left, robot.right);
    robot = exchange(robot);
    printf("�ٲ�÷� %.1lf, %.1lf\n", robot.left, robot.right);
	system("pause");
	return EXIT_SUCCESS;
}

struct vision exchange(struct vision robot) {
    double temp;
    temp = robot.left;
    robot.left = robot.right;
    robot.right = temp;
    return robot;
}