/*
  filename - main.c
  version - 1.0
  description - �⺻ ���� �Լ�
  --------------------------------------------------------------------------------
  first created - 2020.02.01
  writer - Hugo MG Sung.
*/

#include <stdio.h>
#include <stdlib.h>

// �����Լ�
int main(void) 
{
    int score[5];
    int total = 0;
    double avg;
    int count;

    count = sizeof(score) / sizeof(score[0]);

    for (int i = 0; i < count; i++)
    {
        scanf("%d", &score[i]);
    }    

    for (int i = 0; i < count; i++)
    {
        total += score[i];
    }
    avg = total / (double)count;
    printf("����� %.1lf\n", avg);

	system("pause");
	return EXIT_SUCCESS;
}