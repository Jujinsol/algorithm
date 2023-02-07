#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#define _USE_MATH_DEFINES
#include <math.h>

int main() {
	int a, b;

	while (1)
	{
		scanf("%d %d", &a, &b);
		if (a == 0 && b == 0)
			break;

		if (b % a == 0)
			printf("factor\n");
		else if (a % b == 0)
			printf("multiple\n");
		else
			printf("neither\n");
	}
}