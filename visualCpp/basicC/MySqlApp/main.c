#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif

#include <stdio.h>
#include <stdlib.h>
#include <winsock2.h>
#include <mysql.h>

#pragma comment(lib, "libmysql.lib")\

#define MYSQLUSER "root"				//���� �̸�
#define MYSQLPASSWORD "mysql_p@ssw0rd"		//��й�ȣ
#define MYSQLIP "localhost"			//������ ip �ڱ��ڽ��� localhost �ƴϸ� ipconfig�� �ڽ��� ip�� ģ��.

void loadmysql(char mysqlip[], MYSQL* cons)	//MYSQL ���� �ҷ�����
{
	if (cons == NULL) //cons�� �ʱ�ȭ�� ��������
	{
		fprintf(stderr, "%s\n", mysql_error(cons));		//���� ����Ʈ, printf("%s")�� ����
		Sleep(1000);
		exit(1);
	}
	if (!(mysql_real_connect(cons, mysqlip, MYSQLUSER, MYSQLPASSWORD, NULL, 0, NULL, 0) == NULL)) //mysql������ ���� �����ϸ� 0 �ƴϸ� �ٸ��� ��ȯ
	{
		printf("\n����");
		mysql_set_character_set(cons, "euckr");				//MySQL ���ڸ� �����Ѵ�. ���� ���ϸ� �ѱ��� ©��.
	}
	else {
		fprintf(stderr, "���� ���� : %s\n", mysql_error(cons));
		getchar();
	}

	return;
}

int main(void) {
	
	MYSQL* cons = mysql_init(NULL);				//MYSQL ���� �ʱ�ȭ.

	loadmysql(MYSQLIP, cons);
	printf("MySQL connected\n");

	system("pause");
	return EXIT_SUCCESS;
}