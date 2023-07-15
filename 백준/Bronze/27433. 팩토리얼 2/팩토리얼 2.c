#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

long Fact(long n)
{
    if (n < 1)
        return 1;
    else
    {
        return n * Fact(n - 1);
    }
}

int main()
{
    long num;
    scanf("%ld", &num);
    printf("%ld\n", Fact(num));

    return 0;
}