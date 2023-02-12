#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int arr[1001][1001];

int func(int a, int b)
{
	for (int i = 0; i <= a; i++)
	{
		for (int j = 0; j <= b; j++)
		{
			if (i == j || j == 0)
				arr[i][j] = 1;
			else
			{
				arr[i][j] = (arr[i - 1][j - 1] + arr[i - 1][j]) % 10007;
			}
		}
	}
}

int main()
{
	int a, b;
	scanf("%d %d", &a, &b);
	func(a, b);
	printf("%d", arr[a][b]);
}