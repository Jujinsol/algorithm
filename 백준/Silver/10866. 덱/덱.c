#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <math.h>

int Deque[2000000];
int start = 1000000;
int last = 1000000;

void push_front(int x)
{
	start--;
	Deque[start] = x;	
}

void push_back(int x)
{
	Deque[last] = x;
	last++;
}

void pop_front()
{
	if (start == last && Deque[start] == 0)
		printf("-1\n");
	else
	{
		printf("%d\n", Deque[start]);
		Deque[start] = 0;
		start++;
	}
}

void pop_back()
{
	if (start == last && Deque[start] == 0)
		printf("-1\n");
	else
	{
		last--;
		printf("%d\n", Deque[last]);
		Deque[last] = 0;
	}
}

void size()
{
	if (start == last && Deque[start] == 0)
		printf("0\n");
	else if (start == last)
		printf("1\n");
	else
		printf("%d\n", last - start);
}

int empty()
{
	if (start == last && Deque[start] == 0)
		printf("1\n");
	else
		printf("0\n");
}

int front()
{
	if (start == last && Deque[start] == 0)
		printf("-1\n");
	else
		printf("%d\n", Deque[start]);
}

int back()
{
	if (start == last && Deque[start] == 0)
		printf("-1\n");
	else if (start == last)
		printf("%d\n", Deque[last]);
	else
		printf("%d\n", Deque[last - 1]);
}

int main(void)
{
	int N, num;
	char funcName[15];
	scanf("%d", &N);

	for (int i = 0; i < N; i++)
	{
		scanf("%s", &funcName);

		if (strcmp(funcName, "push_front") == 0)
		{
			scanf("%d", &num);
			push_front(num);
		}
		 if (strcmp(funcName, "push_back") == 0)
		{
			scanf("%d", &num);
			push_back(num);
		}
		 if (strcmp(funcName, "pop_front") == 0)
		{
			pop_front();
		}
		 if (strcmp(funcName, "pop_back") == 0)
		{
			pop_back();
		}
		 if (strcmp(funcName, "size") == 0)
		{
			size();
		}
		 if (strcmp(funcName, "empty") == 0)
		{
			empty();
		}
		 if (strcmp(funcName, "front") == 0)
		{
			front();
		}
		 if (strcmp(funcName, "back") == 0)
		{
			back();
		}
	}
}