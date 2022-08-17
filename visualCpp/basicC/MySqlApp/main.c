#ifdef _MSC_VER
#define _CRT_SECURE_NO_WARNINGS
#endif

#include <stdio.h>
#include <stdlib.h>
#include <winsock2.h>
#include <mysql.h>

#pragma comment(lib, "libmysql.lib")\

#define MYSQLUSER "root"				//유저 이름
#define MYSQLPASSWORD "mysql_p@ssw0rd"		//비밀번호
#define MYSQLIP "localhost"			//연결할 ip 자기자신은 localhost 아니면 ipconfig로 자신의 ip를 친다.

void loadmysql(char mysqlip[], MYSQL* cons)	//MYSQL 서버 불러오기
{
	if (cons == NULL) //cons가 초기화를 못했으면
	{
		fprintf(stderr, "%s\n", mysql_error(cons));		//에러 프린트, printf("%s")와 같음
		Sleep(1000);
		exit(1);
	}
	if (!(mysql_real_connect(cons, mysqlip, MYSQLUSER, MYSQLPASSWORD, NULL, 0, NULL, 0) == NULL)) //mysql서버로 연결 성공하면 0 아니면 다른수 반환
	{
		printf("\n성공");
		mysql_set_character_set(cons, "euckr");				//MySQL 문자를 지정한다. 만약 안하면 한글이 짤림.
	}
	else {
		fprintf(stderr, "연결 오류 : %s\n", mysql_error(cons));
		getchar();
	}

	return;
}

int main(void) {
	
	MYSQL* cons = mysql_init(NULL);				//MYSQL 연결 초기화.

	loadmysql(MYSQLIP, cons);
	printf("MySQL connected\n");

	system("pause");
	return EXIT_SUCCESS;
}