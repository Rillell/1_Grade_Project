#include<stdio.h>
void main()
{
	int num;
	printf("정수 : ");
	scanf("%d", &num);

	if (num % 2 == 0)
	{
		printf("정수는 짝수입니다.\n");
	}
	else
	{
		printf("정수는 홀수입니다.\n");
	}
			

}