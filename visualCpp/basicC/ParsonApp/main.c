/*
  filename - main.c
  version - 1.0
  description - 기본 메인 함수, parson 라이브러리 사용 
  --------------------------------------------------------------------------------
  first created - 2020.02.10.
  writer - Hugo MG Sung.
*/

#include <stdio.h>
#include <stdlib.h>
#include "parson.h"
#include "main.h"

// 메인함수
int main(void) {
    get_jsons_file("example.json"); 
    set_jsons_file("saved.json");

    printf("\n\nall processed!!\n");
	system("pause");
	return EXIT_SUCCESS;
}

void get_jsons_file(char *load_file) {
    JSON_Value* rootValue;
    JSON_Object* rootObject;

    rootValue = json_parse_file(load_file); // Json 파일 로드, 초기화
    rootObject = json_value_get_object(rootValue); //JSON_Value에서 JSON_Object를 획득

    /* 사용 */
    // 객체에서 키에 해당하는 문자열 리턴
    printf("Title : %s\n", json_object_get_string(rootObject, "Title"));

    printf("Year : %d\n", (int)json_object_get_number(rootObject, "Year"));
    printf("Runtime : %d min\n", (int)json_object_get_number(rootObject, "Runtime"));

    printf("Genre: %s\n", json_object_get_string(rootObject, "Genre"));
    printf("Director: %s\n", json_object_get_string(rootObject, "Director"));

    printf("Actors:\n");
    // 객체에서 키에 해당하는 배열을 가져옴
    JSON_Array* array = json_object_get_array(rootObject, "Actors");
    for (int i = 0; i < json_array_get_count(array); i++) {    // 배열 요소 개수 반복
        printf("  %s\n", json_array_get_string(array, i));  // 배열에 인덱스 지정, 문자열 리턴
    }

    // 객체에서 키에 해당하는 숫자를 가져옴
    printf("imdbRating: %.1f\n", json_object_get_number(rootObject, "imdbRating"));

    // 객체에서 키에 해당하는 불 값을 가져옴
    printf("KoreaRelease: %s\n", (json_object_get_boolean(rootObject, "KoreaRelease") == 1) ? "true" : "false");

    /* 해제 */
    json_value_free(rootValue);    // JSON_Value에 할당된 동적 메모리 해제
}

void set_jsons_file(char* save_file) {
    JSON_Value* rootValue;
    JSON_Object* rootObject;

    /* 초기화 */
    rootValue = json_value_init_object();             // JSON_Value 생성 및 초기화
    rootObject = json_value_get_object(rootValue);    // JSON_Value에서 JSON_Object를 얻음

    /* 사용 */
    // 객체에 키를 추가하고 문자열 저장
    json_object_set_string(rootObject, "Title", "Interstellar");

    // 객체에 키를 추가하고 숫자 저장
    json_object_set_number(rootObject, "Year", 2014);
    json_object_set_number(rootObject, "Runtime", 169);

    // 객체에 키를 추가하고 문자열 저장
    json_object_set_string(rootObject, "Genre", "Sci-Fi");
    json_object_set_string(rootObject, "Director", "Christopher Nolan");

    // 객체에 키를 추가하고 배열 생성
    json_object_set_value(rootObject, "Actors", json_value_init_array());

    // 객체에서 배열 포인터를 가져옴
    JSON_Array* actors = json_object_get_array(rootObject, "Actors");

    // 배열에 문자열 요소 추가
    json_array_append_string(actors, "Matthew McConaughey");
    json_array_append_string(actors, "Anne Hathaway");
    json_array_append_string(actors, "Michael Caine");
    json_array_append_string(actors, "Jessica Chastain");
    json_array_append_string(actors, "Casey Affleck");

    // 객체에 키를 추가하고 숫자 저장
    json_object_set_number(rootObject, "imdbRating", 8.6);

    // 객체에 키를 추가하고 불 값 저장
    json_object_set_boolean(rootObject, "KoreaRelease", 1);

    // JSON_Value를 사람이 읽기 쉬운 문자열(pretty)로 만든 뒤 파일에 저장
    json_serialize_to_file_pretty(rootValue, "saved.json");

    /* 해제 */
    json_value_free(rootValue);    // JSON_Value에 할당된 동적 메모리 해제
}