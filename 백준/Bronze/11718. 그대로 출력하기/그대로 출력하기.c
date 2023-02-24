#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <math.h>

int main(void) {
	char a;
	while (scanf("%c", &a) != -1)
		printf("%c", a);
	return 0;
}