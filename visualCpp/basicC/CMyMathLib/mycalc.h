#pragma once

#ifdef CMYMATHLIB_EXPORTS
#define CMYMATHLIB_API __declspec(dllexport)
#else
#define CMYMATHLIB_API __declspec(dllimport)
#endif

extern "C" CMYMATHLIB_API int int_add(int a, int b);

extern "C" CMYMATHLIB_API int int_multi(int a, int b);