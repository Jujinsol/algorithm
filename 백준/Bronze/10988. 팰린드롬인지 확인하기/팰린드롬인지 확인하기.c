#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <math.h>

int main(void) {
    char word[100];
    scanf("%s", &word);

    int start = 0;
    int end = (int)strlen(word);
    int mid = end / 2;

    for (int i = start; i < mid; i++)
    {
        if (word[start] == word[end - 1])
        {
            start++;
            end--;
            continue;
        }
        else
        {
            printf("0");
            exit(0);
        }
    }

    printf("1");

    return 0;
}