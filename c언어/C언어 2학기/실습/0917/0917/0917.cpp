//���� �ϳ��� �Է¹޾� �Ҽ����� �ƴ��� Ȯ��!
/*#include<stdio.h>
void main()
{
	int num, i;
	printf("����: ");
	scanf("%d", &num);

	for (i = 2; i < num; i++)
	{
		if (num % i == 0) break;
	}
	if (i == num) printf("O\n");
	else          printf("X\n");
}*/




//2~100������ ���߿��� �Ҽ��� ���
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
			if (counter % 7 == 0)  printf("\n");  //7�� ����ϰ� ��������
		}
	}
	printf("\n\n�Ҽ��� ���� : %d��\n\n", counter);
}