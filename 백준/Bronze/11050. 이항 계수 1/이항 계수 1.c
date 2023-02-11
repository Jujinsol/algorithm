#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int Fact(int a)
{
	int sum = 1;
	for (int i = 1; i <= a; i++)
		sum *= i;
	return sum;
}

int main()
{
	int a, b;
	scanf("%d %d", &a, &b);
	printf("%d", (Fact(a) / (Fact(a - b) * Fact(b))));
}