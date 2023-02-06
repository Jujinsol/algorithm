#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <stdlib.h>
#define _USE_MATH_DEFINES
#include <math.h>

int main() {
	const double r;
	scanf("%lf", &r);

	printf("%.6f\n", r * r * M_PI);
	printf("%.6f", 2 * r * r);
}