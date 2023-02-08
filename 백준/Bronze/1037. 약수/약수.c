#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#define _USE_MATH_DEFINES
#include <string.h>

int cmp(const void* a, const void* b) 
{
	return *(int*)a > *(int*)b ? 1 : (*(int*)a < *(int*)b ? -1 : 0);
}

int main() {
	int a;
	scanf("%d", &a);
	int* arr = malloc(sizeof(int) * a);

	for (int i = 0; i < a; i++)
		scanf("%d", &arr[i]);

	qsort(arr, a, sizeof(arr[0]), cmp);

	if (a == 1)
		printf("%d", arr[0] * arr[0]);
	else
		printf("%d", arr[0] * arr[a - 1]);
}