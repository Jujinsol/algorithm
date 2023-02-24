#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int arr[100001];

int main(void) 
{
    int n, m;    
    scanf("%d %d", &n, &m);
    int* sum = malloc(sizeof(int) * (n + 1));

    for (int i = 0; i < n; i++)
        scanf("%d", &arr[i]);

    sum[0] = 0;

    for (int i = 1; i < n + 1; i++)
    {
        sum[i] = sum[i - 1] + arr[i - 1];
    }

    int count = 0;
    int max = 0;

    for (int i = 0; i < n - m + 1; i++)
    {
        if (i == 0)
            max = sum[i + m] - sum[i];
        else if (sum[i + m] - sum[i] > max)
            max = sum[i + m] - sum[i];
    }

    printf("%d", max);

    return 0;
}
