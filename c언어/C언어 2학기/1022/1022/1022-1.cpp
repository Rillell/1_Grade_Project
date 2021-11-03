#include<stdio.h>
void main()
{
	int arr[5] = { 10,20,30,40,50 };
	int *p;
	p = arr;
	printf("%d     %d\n", arr[0], *p);
	p = p + 1;
	printf("%d     %d\n", arr[1], *p);
}

//{
//	int arr[5] = { 10,20,30,40,50 };
//	int *p;
//	int i;
//	p = arr;
//
//	for (i = 0; i < 5; i++)
//		printf("%d\n", arr[i]);
//	for (i = 0; i < 5; i++)
//		printf("%d\n", *p++);
//}