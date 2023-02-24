#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <math.h>

int main(void) {
    int n;
    scanf("%d", &n);
    
    int start = 0;
    int end;

    char word[1000];

    for (int i = 0; i < n; i++)
    {
        scanf("%s", &word);
        end = (int)strlen(word) - 1;

        printf("%c", word[start]);
        printf("%c", word[end]);
        printf("\n");
    }

    return 0;
}