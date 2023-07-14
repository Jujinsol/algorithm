#include <stdio.h>

int main()
{
    int num;
    char word[1000];
    scanf("%s", word);
    scanf("%d", &num);

    printf("%c", word[num - 1]);

    return 0;
}