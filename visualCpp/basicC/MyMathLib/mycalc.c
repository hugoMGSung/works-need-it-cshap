#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include "mycalc.h"

#ifdef __cplusplus
extern "C" {
#endif // __cplusplus

	_declspec(dllexport) int int_add(int a, int b) { return a + b; }
	_declspec(dllexport) int int_multi(int a, int b) { return a * b; }

#ifdef __cplusplus
}
#endif // __cplusplus