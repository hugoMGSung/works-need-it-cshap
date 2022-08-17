/*
  filename - main.c
  version - 1.0
  description - �⺻ ���� �Լ�, parson ���̺귯�� ��� 
  --------------------------------------------------------------------------------
  first created - 2020.02.10.
  writer - Hugo MG Sung.
*/

#include <stdio.h>
#include <stdlib.h>
#include "parson.h"
#include "main.h"

// �����Լ�
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

    rootValue = json_parse_file(load_file); // Json ���� �ε�, �ʱ�ȭ
    rootObject = json_value_get_object(rootValue); //JSON_Value���� JSON_Object�� ȹ��

    /* ��� */
    // ��ü���� Ű�� �ش��ϴ� ���ڿ� ����
    printf("Title : %s\n", json_object_get_string(rootObject, "Title"));

    printf("Year : %d\n", (int)json_object_get_number(rootObject, "Year"));
    printf("Runtime : %d min\n", (int)json_object_get_number(rootObject, "Runtime"));

    printf("Genre: %s\n", json_object_get_string(rootObject, "Genre"));
    printf("Director: %s\n", json_object_get_string(rootObject, "Director"));

    printf("Actors:\n");
    // ��ü���� Ű�� �ش��ϴ� �迭�� ������
    JSON_Array* array = json_object_get_array(rootObject, "Actors");
    for (int i = 0; i < json_array_get_count(array); i++) {    // �迭 ��� ���� �ݺ�
        printf("  %s\n", json_array_get_string(array, i));  // �迭�� �ε��� ����, ���ڿ� ����
    }

    // ��ü���� Ű�� �ش��ϴ� ���ڸ� ������
    printf("imdbRating: %.1f\n", json_object_get_number(rootObject, "imdbRating"));

    // ��ü���� Ű�� �ش��ϴ� �� ���� ������
    printf("KoreaRelease: %s\n", (json_object_get_boolean(rootObject, "KoreaRelease") == 1) ? "true" : "false");

    /* ���� */
    json_value_free(rootValue);    // JSON_Value�� �Ҵ�� ���� �޸� ����
}

void set_jsons_file(char* save_file) {
    JSON_Value* rootValue;
    JSON_Object* rootObject;

    /* �ʱ�ȭ */
    rootValue = json_value_init_object();             // JSON_Value ���� �� �ʱ�ȭ
    rootObject = json_value_get_object(rootValue);    // JSON_Value���� JSON_Object�� ����

    /* ��� */
    // ��ü�� Ű�� �߰��ϰ� ���ڿ� ����
    json_object_set_string(rootObject, "Title", "Interstellar");

    // ��ü�� Ű�� �߰��ϰ� ���� ����
    json_object_set_number(rootObject, "Year", 2014);
    json_object_set_number(rootObject, "Runtime", 169);

    // ��ü�� Ű�� �߰��ϰ� ���ڿ� ����
    json_object_set_string(rootObject, "Genre", "Sci-Fi");
    json_object_set_string(rootObject, "Director", "Christopher Nolan");

    // ��ü�� Ű�� �߰��ϰ� �迭 ����
    json_object_set_value(rootObject, "Actors", json_value_init_array());

    // ��ü���� �迭 �����͸� ������
    JSON_Array* actors = json_object_get_array(rootObject, "Actors");

    // �迭�� ���ڿ� ��� �߰�
    json_array_append_string(actors, "Matthew McConaughey");
    json_array_append_string(actors, "Anne Hathaway");
    json_array_append_string(actors, "Michael Caine");
    json_array_append_string(actors, "Jessica Chastain");
    json_array_append_string(actors, "Casey Affleck");

    // ��ü�� Ű�� �߰��ϰ� ���� ����
    json_object_set_number(rootObject, "imdbRating", 8.6);

    // ��ü�� Ű�� �߰��ϰ� �� �� ����
    json_object_set_boolean(rootObject, "KoreaRelease", 1);

    // JSON_Value�� ����� �б� ���� ���ڿ�(pretty)�� ���� �� ���Ͽ� ����
    json_serialize_to_file_pretty(rootValue, "saved.json");

    /* ���� */
    json_value_free(rootValue);    // JSON_Value�� �Ҵ�� ���� �޸� ����
}