#include <stdio.h>
#include "cursor.h"
#include <new>
#include <time.h>

/** 하지말것 */
int main()
{
	int* pi[1000] = { NULL, };
	int i;

	try {
		for (i = 0;; i++) {
			pi[i] = new int[10000000];
			if (pi[i]) {
				printf("%d번째 할당 성공\n", i);
			}
			else {
				printf("%d번째 할당 실패\n", i);
			}
			_sleep(1000);
		}
	}
	catch (std::bad_alloc& b) {
		puts("에러 발생");
		b.what();
	}
	for (i = 0;; i++) {
		delete[] pi[i];
	}
}