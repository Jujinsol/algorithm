#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int gcd(int a, int b)
{
	if (a % b == 0)
		return b;
	else
		gcd(b, a % b);
}

int main()
{
	int n;
	scanf("%d", &n);
	int* arr = malloc(sizeof(int) * n);
	for (int i = 0; i < n; i++)
		scanf("%d", &arr[i]);

	for (int i = 1; i < n; i++)
	{
		printf("%d/%d\n", arr[0] / gcd(arr[0], arr[i]), arr[i] / gcd(arr[0], arr[i]));
	}
}