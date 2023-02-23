#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(void) {
    int n, m, i, j;
    scanf("%d %d", &n, &m);
    int* arr = malloc(sizeof(int) * n);

    for (int x = 0; x < n; x++)
        arr[x] = x + 1;

    for (int x = 0; x < m; x++)
    {
        scanf("%d %d", &i, &j);

        int temp = arr[i - 1];
        arr[i - 1] = arr[j - 1];
        arr[j - 1] = temp;
    }

    for (int x = 0; x < n; x++)
        printf("%d ", arr[x]);

    return 0;
}
