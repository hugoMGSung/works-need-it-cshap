#include <stdio.h>

#define MYSQLUSER "root"				//���� �̸�
#define MYSQLPASSWORD "mysql_p@ssw0rd"	//��й�ȣ
#define MYSQLIP "210.119.12.52"			//������ ip �ڱ��ڽ��� localhost �ƴϸ� ipconfig�� �ڽ��� ip�� ģ��.

class DBQuery {
private:
	static int hCon;
	int nResult;
public:
	DBQuery() {};
	static void DBConnect(const char* Server, const char* ID, const char* Pass);
	static void DBDisConnect();
	bool RunQuery(const char* SQL);
	// ...
};

int DBQuery::hCon;

void DBQuery::DBConnect(const char* Server, const char* ID, const char* Pass) {
	// ���⼭ DB������ ����
	//MYSQL* hCon = mysql_init(NULL);
	//mysql_real_connect(&hCon, Server, ID, Pass, NULL, 0, NULL, 0);
	hCon = 1234; // ���ǰ�
	puts("���Ἲ��");
}

void DBQuery::DBDisConnect() {
	// ��������
	//mysql_close(hCon);
	hCon = NULL;
	puts("��������");
}

bool DBQuery::RunQuery(const char* SQL) {	
	//mysql_query(hCon, SQL);
	puts(SQL);
	return true;
}

int main() {
	//DBQuery* dbcon = new DBQuery();
	//DBQuery dbcon2();

	//dbcon->DBConnect("210.119.12.52", "root", "mysql_p@ssw0rd");

	//DBQuery::DBConnect("210.119.12.52", "root", "mysql_p@ssw0rd");
	DBQuery::DBConnect(MYSQLIP, MYSQLUSER, MYSQLPASSWORD);
	DBQuery con1, con2, con3;
	// �ʿ��� DB��������
	con1.RunQuery("SELECT * FROM usertbl WHERE userID = 'KBS';");
	// ...
	DBQuery::DBDisConnect();

	return 0;
}
