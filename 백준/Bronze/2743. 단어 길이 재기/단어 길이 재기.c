#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <math.h>

int main(void) {
    char word[100];
    scanf("%s", &word);

    printf("%d", (int)strlen(word));

    return 0;
}