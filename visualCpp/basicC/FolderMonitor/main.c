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
#include <conio.h>

#define FILE_PATH "D:\\Document"
void search_directory(char* path);

// �����Լ�
int main(void) 
{
    while (1) {
        if (_kbhit()) {
            if (getch() == 'x') {
                break;
            }
            else {
                _sleep(1000);
                // �ƴ� ��� ���� �ݺ� �Ϸ��� �۾�
                search_directory(FILE_PATH);
            }
        }
    }

	system("pause");
	return EXIT_SUCCESS;
}

void search_directory(char* path) {
    intptr_t handle;
    int check = 0;


}