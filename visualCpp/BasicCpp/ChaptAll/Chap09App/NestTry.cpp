#include <stdio.h>
#include <conio.h>
#include <string.h>

int main() {
	int num;
	int age;
	char name[12];
	int height;

	try
	{
		printf("학번을 입력하세요 : ");
		scanf("%d", &num);
		if (num <= 0) throw num;

		try
		{
			printf("이름을 입력하세요 : ");
			scanf("%s", name);
			//printf("%d\n", strlen(name));
			if (strlen(name) < 4) throw name; // "[ERROR] 이름이 너무 짧음";
			printf("나이를 입력하세요 : ");
			scanf("%d", &age);
			if (age <= 0) throw age;

			try
			{
				printf("키를 입력 : ");
				scanf("%d", &height);
				if (height <= 0) throw height;
			}
			catch (int a)
			{
				throw;
			}

			printf("입력한 정보, 학번 %d, 이름 %s, 나이 %d\n", num, name, age);
		}
		catch (const char* msg)
		{
			printf("[ERROR] %s 는 너무 짧습니다\n", msg);
		}
		catch (int) 
		{
			throw;
		}
	}
	catch (int n)
	{
		printf("[ERROR] %d는 0또는 음수로 적합하지 않음\n", n);
	}
}

