#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#include <math.h>

int main(void) {
    int n, m, i, j, k;
    scanf("%d %d", &n, &m);
    int* arr = malloc(sizeof(int) * n);

    for (int x = 0; x < n; x++)
        arr[x] = 0;

    for (int x = 0; x < m; x++)
    {
        scanf("%d %d %d", &i, &j, &k);

        int o = i - 1;
        for (int y = 0; y <= j - i; y++)
        {
            arr[o] = k;
            o++;            
        }
    }

    for (int x = 0; x < n; x++)
        printf("%d ", arr[x]);

    return 0;
}
