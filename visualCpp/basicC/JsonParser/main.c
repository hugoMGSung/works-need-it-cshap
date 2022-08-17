/*
  filename - main.c
  version - 1.0
  description - �⺻ ���� �Լ�
  --------------------------------------------------------------------------------
  first created - 2020.02.01
  writer - Hugo MG Sung.
*/

#include <stdio.h>     // ���� ó�� �Լ��� ����� ��� ����
#include <stdlib.h>    // malloc, free �Լ��� ����� ��� ����
#include <stdbool.h>   // bool, true, false�� ���ǵ� ��� ����
#include <string.h>    // strchr, memset, memcpy �Լ��� ����� ��� ����

// ��ū ���� ������
typedef enum _TOKEN_TYPE {
	TOKEN_STRING,    // ���ڿ� ��ū
	TOKEN_NUMBER,    // ���� ��ū
} TOKEN_TYPE;

// ��ū ����ü
typedef struct _TOKEN {
	TOKEN_TYPE type;   // ��ū ����
	union {            // �� ���� �� �� ������ ������ ���̹Ƿ� ����ü�� ����
		char* string;     // ���ڿ� ������
		double number;    // �Ǽ��� ����
	};
	bool isArray;      // ���� ��ū�� �迭���� ǥ��
} TOKEN;

#define TOKEN_COUNT 20    // ��ū�� �ִ� ����

// JSON ����ü
typedef struct _JSON {
	TOKEN tokens[TOKEN_COUNT]; // ��ū �迭
} JSON;

char* readFile(char* filename, int* readSize) {   // ������ �о ������ ��ȯ�ϴ� �Լ�
	FILE* fp = fopen(filename, "rb");
	if (fp == NULL) { return NULL; }

	int size;
	char* buffer;

	fseek(fp, 0, SEEK_END);    // ���� ũ�� ���ϱ�
	size = ftell(fp);
	fseek(fp, 0, SEEK_SET);

	buffer = calloc(1, size + 1);     // ���� ũ�� + NULL ������ŭ �޸𸮸� �Ҵ��ϰ� 0���� �ʱ�ȭ  //memset(buffer, 0, size + 1);

	if (fread(buffer, size, 1, fp) < 1) {    // ���� ���� �б�
		*readSize = 0;
		free(buffer);
		fclose(fp);
		return NULL;
	}

	*readSize = size;    // ���� ũ�⸦ �Ѱ���
	fclose(fp);    // ���� ������ �ݱ�
	return buffer;
}

void parseJSON(char* doc, int size, JSON* json) {   // JSON �Ľ� �Լ�
	int tokenIndex = 0;    // ��ū �ε���
	int pos = 0;           // ���� �˻� ��ġ�� �����ϴ� ����

	if (doc[pos] != '{') { return; }   // ������ ������ {���� �˻�
	pos++;    // ���� ���ڷ�

	while (pos < size) {      // ���� ũ�⸸ŭ �ݺ�
		switch (doc[pos]) {   // ������ ������ ���� �б�
		case '"':            // ���ڰ� "�̸� ���ڿ�
		{
			char* begin = doc + pos + 1; // ���ڿ��� ���� ��ġ�� ����. �� ���� "�� �����ϱ� ���� + 1
			char* end = strchr(begin, '"'); // ���ڿ��� �� ��ġ�� ����. ���� "�� ��ġ
			if (end == NULL) { break; }   // "�� ������ �߸��� �����̹Ƿ� �ݺ� ����

			int stringLength = end - begin;    // ���ڿ��� ���� ���̴� �� ��ġ - ���� ��ġ
			json->tokens[tokenIndex].type = TOKEN_STRING;  // ��ū �迭�� ���ڿ� ����
			json->tokens[tokenIndex].string = calloc(1, stringLength + 1); // ���ڿ� ���� + NULL ������ŭ �޸� �Ҵ�
			// memset(json->tokens[tokenIndex].string, 0, stringLength + 1);
			memcpy(json->tokens[tokenIndex].string, begin, stringLength); // ���ڿ� ���� ��ġ���� ���ڿ� ���̸�ŭ�� ����
			tokenIndex++; // ��ū �ε��� ����
			pos = pos + stringLength + 1;    // ���� ��ġ + ���ڿ� ���� + "(+ 1)
		}
		break;
		}
		pos++; // ���� ���ڷ�
	}
}

void freeJSON(JSON* json) {   // JSON ���� �Լ�
	for (int i = 0; i < TOKEN_COUNT; i++) {           // ��ū ������ŭ �ݺ�
		if (json->tokens[i].type == TOKEN_STRING) {   // ��ū ������ ���ڿ��̸�
			free(json->tokens[i].string);            // ���� �޸� ����
		}
	}
}

// �����Լ�
int main(void) {
	int size;
	char* doc = readFile("sample.json", &size);
	if (doc == NULL) { return EXIT_FAILURE; }
	JSON json = { 0, };             // JSON ����ü ���� ���� �� �ʱ�ȭ
	parseJSON(doc, size, &json);    // JSON ���� �Ľ�

	int i = 0;
	while (true) {
		if (json.tokens[i].string == 0) { break; }
		printf("%s: %s\n", json.tokens[i].string, json.tokens[i + 1].string);
		i += 2;
	}

	freeJSON(&json);    // json�� �Ҵ�� ���� �޸� ����
	free(doc);    // ���� ���� �޸� ����

	system("pause");
	return EXIT_SUCCESS;
}