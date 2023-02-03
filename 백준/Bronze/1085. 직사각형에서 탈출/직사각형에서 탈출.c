#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>

int main() {
	int x, y, w, h;

	scanf("%d %d %d %d", &x, &y, &w, &h);
	int min = x;

	if (min > y)
		min = y;
	if (min > w - x)
		min = w - x;
	if (min > h - y)
		min = h - y;

	printf("%d", min);
}