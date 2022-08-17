/*
  filename - main.c
  version - 1.0
  description - 기본 메인 함수
  --------------------------------------------------------------------------------
  first created - 2020.02.01
  writer - Hugo MG Sung.
*/

#include <stdio.h>     // 파일 처리 함수가 선언된 헤더 파일
#include <stdlib.h>    // malloc, free 함수가 선언된 헤더 파일
#include <stdbool.h>   // bool, true, false가 정의된 헤더 파일
#include <string.h>    // strchr, memset, memcpy 함수가 선언된 헤더 파일

// 토큰 종류 열거형
typedef enum _TOKEN_TYPE {
	TOKEN_STRING,    // 문자열 토큰
	TOKEN_NUMBER,    // 숫자 토큰
} TOKEN_TYPE;

// 토큰 구조체
typedef struct _TOKEN {
	TOKEN_TYPE type;   // 토큰 종류
	union {            // 두 종류 중 한 종류만 저장할 것이므로 공용체로 만듦
		char* string;     // 문자열 포인터
		double number;    // 실수형 숫자
	};
	bool isArray;      // 현재 토큰이 배열인지 표시
} TOKEN;

#define TOKEN_COUNT 20    // 토큰의 최대 개수

// JSON 구조체
typedef struct _JSON {
	TOKEN tokens[TOKEN_COUNT]; // 토큰 배열
} JSON;

char* readFile(char* filename, int* readSize) {   // 파일을 읽어서 내용을 반환하는 함수
	FILE* fp = fopen(filename, "rb");
	if (fp == NULL) { return NULL; }

	int size;
	char* buffer;

	fseek(fp, 0, SEEK_END);    // 파일 크기 구하기
	size = ftell(fp);
	fseek(fp, 0, SEEK_SET);

	buffer = calloc(1, size + 1);     // 파일 크기 + NULL 공간만큼 메모리를 할당하고 0으로 초기화  //memset(buffer, 0, size + 1);

	if (fread(buffer, size, 1, fp) < 1) {    // 파일 내용 읽기
		*readSize = 0;
		free(buffer);
		fclose(fp);
		return NULL;
	}

	*readSize = size;    // 파일 크기를 넘겨줌
	fclose(fp);    // 파일 포인터 닫기
	return buffer;
}

void parseJSON(char* doc, int size, JSON* json) {   // JSON 파싱 함수
	int tokenIndex = 0;    // 토큰 인덱스
	int pos = 0;           // 문자 검색 위치를 저장하는 변수

	if (doc[pos] != '{') { return; }   // 문서의 시작이 {인지 검사
	pos++;    // 다음 문자로

	while (pos < size) {      // 문서 크기만큼 반복
		switch (doc[pos]) {   // 문자의 종류에 따라 분기
		case '"':            // 문자가 "이면 문자열
		{
			char* begin = doc + pos + 1; // 문자열의 시작 위치를 구함. 맨 앞의 "를 제외하기 위해 + 1
			char* end = strchr(begin, '"'); // 문자열의 끝 위치를 구함. 다음 "의 위치
			if (end == NULL) { break; }   // "가 없으면 잘못된 문법이므로 반복 종료

			int stringLength = end - begin;    // 문자열의 실제 길이는 끝 위치 - 시작 위치
			json->tokens[tokenIndex].type = TOKEN_STRING;  // 토큰 배열에 문자열 저장
			json->tokens[tokenIndex].string = calloc(1, stringLength + 1); // 문자열 길이 + NULL 공간만큼 메모리 할당
			// memset(json->tokens[tokenIndex].string, 0, stringLength + 1);
			memcpy(json->tokens[tokenIndex].string, begin, stringLength); // 문자열 시작 위치에서 문자열 길이만큼만 복사
			tokenIndex++; // 토큰 인덱스 증가
			pos = pos + stringLength + 1;    // 현재 위치 + 문자열 길이 + "(+ 1)
		}
		break;
		}
		pos++; // 다음 문자로
	}
}

void freeJSON(JSON* json) {   // JSON 해제 함수
	for (int i = 0; i < TOKEN_COUNT; i++) {           // 토큰 개수만큼 반복
		if (json->tokens[i].type == TOKEN_STRING) {   // 토큰 종류가 문자열이면
			free(json->tokens[i].string);            // 동적 메모리 해제
		}
	}
}

// 메인함수
int main(void) {
	int size;
	char* doc = readFile("sample.json", &size);
	if (doc == NULL) { return EXIT_FAILURE; }
	JSON json = { 0, };             // JSON 구조체 변수 선언 및 초기화
	parseJSON(doc, size, &json);    // JSON 문서 파싱

	int i = 0;
	while (true) {
		if (json.tokens[i].string == 0) { break; }
		printf("%s: %s\n", json.tokens[i].string, json.tokens[i + 1].string);
		i += 2;
	}

	freeJSON(&json);    // json에 할당된 동적 메모리 해제
	free(doc);    // 문서 동적 메모리 해제

	system("pause");
	return EXIT_SUCCESS;
}