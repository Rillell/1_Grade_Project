#include<stdio.h>
#include<stdlib.h>
#include<time.h>
void main()
/*{
	int rnum;
	srand((unsigned)time(NULL));
	rnum = rand() & 8; //0~7������ ������ ���
	printf("%d\n", rnum);
	rnum = rand() & 8 + 2; //2~9������ ������ ���
	printf("%d\n", rnum);
}*/

/*
m~n => 0~m-n
rand()%(n-m+1)+m
*/

{
	int num1, num2, rnum, tmp;
	srand((unsigned)time(NULL));
	printf("�� ����: ");
	scanf("%d%d", &num1, &num2);

	if (num1 > num2)
	{
		tmp = num1;
		num1 = num2;
		num2 = tmp; //ū��, ������ ����
	}
	
	
	rnum = rand() % (num2 - num1 + 1) + num1;

	printf("%d => ", rnum);
	if (rnum % 2 == 0) printf("%d�� ¦���Դϴ�.", rnum);
	else
		printf("%d�� Ȧ���Դϴ�.", rnum);
}