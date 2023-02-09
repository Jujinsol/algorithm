#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>

int main() {
	int n, a, b, c;

	scanf("%d", &n);

	for (int j = 0; j < n; j++)
	{
		scanf("%d %d", &a, &b);

		for (int i = 1; i <= a && i <= b; i++)
		{
			if (a % i == 0 && b % i == 0)
				c = i;
		}

		printf("%d\n", (a * b) / c);
	}
}