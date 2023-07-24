#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <math.h>

int main()
{
    int A1, B1, A2, B2, X, Y, temp;
    scanf("%d%d%d%d", &A1, &B1, &A2, &B2);

    X = (A1 * B2) + (A2 * B1);
    Y = B1 * B2;

    int i;
    temp = X;
    for (i = sqrt(temp); i >= 2; i--)
    {
        if (((X % i) == 0) && ((Y % i) == 0))
        {
            X /= i;
            Y /= i;
        }
    }

    printf("%d %d", X, Y);
    return 0;
}