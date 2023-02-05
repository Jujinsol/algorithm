#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>

int main() {
	
	int x, y, z, max, min1, min2;

	while (1)
	{
		scanf("%d %d %d", &x, &y, &z);
		if (x == 0 && y == 0 && z == 0)
			break;

		if (x > y && x > z)
			max = x, min1 = y, min2 = z;
		else if (y > x && y > z)
			max = y, min1 = x, min2 = z;
		if (z > x && z > y)
			max = z, min1 = y, min2 = x;

		if ((max * max) == (min1 * min1) + (min2 * min2))
			printf("right\n");
		else
			printf("wrong\n");
	}
}