#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int Solution(int n, int k)
{
    for (int i = 1; i <= n; i++)
    {
        if (n % i == 0)
        {
            k--;
            if (k == 0)
                return i;
        }
    }

    return 0;
}

int main(void) {
    int n;
    int k;

    scanf("%d %d", &n, &k);
    printf("%d", Solution(n, k));

    return 0;
}
