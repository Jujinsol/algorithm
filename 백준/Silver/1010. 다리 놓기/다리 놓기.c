#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
	int n;
	scanf("%d", &n); 
	int a, b;
	long long c;

	for (int i = 0; i < n; i++)
	{
		scanf("%d %d", &a, &b);

		c = 1;
		for (int j = 0; j < a; j++)
		{
			c *= b - j;
			c /= 1 + j;
		}

		printf("%d\n", c);
	}
}