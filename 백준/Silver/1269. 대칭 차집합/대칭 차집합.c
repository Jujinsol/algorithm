#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>

int Binary(int* A, int size, int find)
{
	int left = 0, right = size - 1;
	while (left <= right)
	{
		int mid = (left + right) / 2;
		
		if (A[mid] == find)
			return 1;
		else if (A[mid] < find)
		{
			left = mid + 1;
		}
		else if (A[mid] > find)
		{
			right = mid - 1;
		}
	}
	return 0;
}

int compare(const void *a, const void *b)
{
	return *((int*)a) - *((int*)b);
}

int main(void)
{
	int N, M;
	scanf("%d %d", &N, &M);

	int* A = malloc(sizeof(int) *N);
	for (int i = 0; i < N; i++)
		scanf("%d", &A[i]);

	qsort(A, N, sizeof(int), compare);
	int count = 0;
	for (int i = 0; i < M; i++)
	{
		int find;
		scanf("%d", &find);
		count += Binary(A, N, find);
	}

	printf("%d\n", N + M - count * 2);

	return 0;
}