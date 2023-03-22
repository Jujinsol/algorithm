// Lab3-ACM
#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
// 단위 분수의 합으로 a/b 를 구하고 가장 마지막 단위분수 1/x 를 구하고
// x 를 return 한다.
// 1/x1 <= a/b 인 최대값 x1을 구하고 a/b 에서 1/x1을 뺀 값에 대하여 반복한다.
#define MAX(x, y) ((x>y) ? (x) : (y))
#define MIN(x, y) ((x<y) ? (x) : (y))

int find_last_x(int a, int b)
{
	if (a == 1)
	{
		printf("%d\n",b);
	}
	else
	{
		int x, y, a1, b1, i, div;
		x = 1;
		y = b / a + 1;
		//printf("%d/%d + ", x, y);
		a1 = a * y - b * x;
		b1 = b * y;
		for (i = 1; i <= a1 && i <= b1; i++)
		{
			if (a1 % i == 0 && b1 % i == 0)
				div = i;
		}
		a1 /= div;
		b1 /= div;
		return find_last_x(a1, b1);
	}
}

void main()
{
	int n_test;
	int a, b; // a/b
	scanf("%d", &n_test);
	while (n_test--) {
		scanf("%d %d", &a, &b); // input a  b
		find_last_x(a, b);
	}
}