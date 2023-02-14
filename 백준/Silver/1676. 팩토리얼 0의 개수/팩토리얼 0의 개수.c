#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>

int main()
{
	int n, count;
	long long sum, a;
	scanf("%d", &n); 	
	sum = 1, count = 0;

	for (int i = 1; i <= n; i++)
	{
		if (i % 5 == 0)
			count++;
		if (i % 25 == 0)
			count++;
		if (i % 125 == 0)
			count++;			
	}

	printf("%d", count);
}