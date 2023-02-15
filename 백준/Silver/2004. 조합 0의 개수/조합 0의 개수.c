#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main()
{
	int n, m;
	scanf("%d %d", &n, &m);
	
	int count1 = 0;
	int count2 = 0;
	long long a = 5;
	long long b = 2;

	while (n / a)
	{
		count1 += n / a - (n - m) / a;
		a *= 5;
	}
	a = 5;
	while (m / a)
	{
		count1 -= m / a;
		a *= 5;
	}

	while (n / b)
	{
		count2 += n / b - (n - m) / b;
		b *= 2;
	}
	b = 2;
	while (m / b)
	{
		count2 -= m / b;
		b *= 2;
	}


	printf("%d\n", count1 < count2 ? count1 : count2);
}