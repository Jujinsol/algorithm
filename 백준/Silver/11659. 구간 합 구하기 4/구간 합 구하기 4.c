#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int arr[100001];

int main(void) {
    int n, m, i, j;    
    scanf("%d %d", &n, &m);

    int* sum = malloc(sizeof(int) * n);

    for (int x = 0; x < n; x++)
        scanf("%d ", &arr[x]);

    sum[0] = 0;
    for (int x = 1; x < n + 1; x++)
    {
        sum[x] = sum[x - 1] + arr[x - 1];
    }

    for (int x = 0; x < m; x++)
    {
        scanf("%d %d", &i, &j);

        printf("%d\n", sum[j] - sum[i - 1]);
    }

    return 0;
}
