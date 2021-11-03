//정수 하나를 입력받아 소수인지 아닌지 확인!
/*#include<stdio.h>
void main()
{
	int num, i;
	printf("정수: ");
	scanf("%d", &num);

	for (i = 2; i < num; i++)
	{
		if (num % i == 0) break;
	}
	if (i == num) printf("O\n");
	else          printf("X\n");
}*/




//2~100사이의 수중에서 소수만 출력
#include<stdio.h>
void main()
{
	int i, num, counter=0;

	for (num = 2; num <= 100; num++)
	{
		for (i = 2; i < num; i++)
			if (num % i == 0) break;

		if (i == num) 
		{
			printf("%5d", num);
			counter++;
			if (counter % 7 == 0)  printf("\n");  //7개 출력하고 내려가라
		}
	}
	printf("\n\n소수의 개수 : %d개\n\n", counter);
}