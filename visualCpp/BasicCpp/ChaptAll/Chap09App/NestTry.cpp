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
		printf("�й��� �Է��ϼ��� : ");
		scanf("%d", &num);
		if (num <= 0) throw num;

		try
		{
			printf("�̸��� �Է��ϼ��� : ");
			scanf("%s", name);
			//printf("%d\n", strlen(name));
			if (strlen(name) < 4) throw name; // "[ERROR] �̸��� �ʹ� ª��";
			printf("���̸� �Է��ϼ��� : ");
			scanf("%d", &age);
			if (age <= 0) throw age;

			try
			{
				printf("Ű�� �Է� : ");
				scanf("%d", &height);
				if (height <= 0) throw height;
			}
			catch (int a)
			{
				throw;
			}

			printf("�Է��� ����, �й� %d, �̸� %s, ���� %d\n", num, name, age);
		}
		catch (const char* msg)
		{
			printf("[ERROR] %s �� �ʹ� ª���ϴ�\n", msg);
		}
		catch (int) 
		{
			throw;
		}
	}
	catch (int n)
	{
		printf("[ERROR] %d�� 0�Ǵ� ������ �������� ����\n", n);
	}
}

