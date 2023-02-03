#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>

int main() {
	int a[2];
	int b[2];
	int c[2];

	scanf("%d %d", &a[0], &a[1]);
	scanf("%d %d", &b[0], &b[1]);
	scanf("%d %d", &c[0], &c[1]);

	int x = a[0];
	if (x == b[0])
		x = c[0];
	else if (x == c[0])
		x = b[0];

	int y = a[1];
	if (y == b[1])
		y = c[1];
	else if (y == c[1])
		y = b[1];

	printf("%d %d", x, y);
}