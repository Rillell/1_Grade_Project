#include<stdio.h>
void main()
{
	typedef int integer; // int => integer   typedef = ������ ����

	int num = 10;

	integer num1 = 20;

	printf("%d   %d\n", num, num1);
}