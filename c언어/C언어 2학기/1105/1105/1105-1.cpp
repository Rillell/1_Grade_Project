#include<stdio.h>
void main()
{
	typedef int integer; // int => integer   typedef = 별명같은 개념

	int num = 10;

	integer num1 = 20;

	printf("%d   %d\n", num, num1);
}