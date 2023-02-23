#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int arr[100000];
int k;
int Solution(int n)
{
    int sum = 0;
    k = 0;
    for (int i = 1; i < n; i++)
    {
        if (n % i == 0)
        {
            sum += i;
            arr[k] = i;
            k++;
        }
    }
    if (sum == n)
        return 1;
    else
        return 0;
}

int main(void) {
    int n = 0;

    while (n != -1)
    {
        scanf("%d", &n);
        if (Solution(n) == 1)
        {
            printf("%d = ", n);
            for (int i = 0; i < k; i++)
            {
                if (i != 0)
                    printf("+ ");
                printf("%d ", arr[i]);
            }
            printf("\n");
        }
        else
        {
            if (n == -1)
                break;
            printf("%d is NOT perfect.\n", n);
        }
    }

    return 0;
}
