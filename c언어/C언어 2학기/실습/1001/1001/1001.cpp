#include<stdio.h>
#include<stdlib.h>
#include<time.h>
void main()
//아래와 같은 배열을 만들고 21 ~ 50사이의 난수를 채운후 가로 합과 세로 합을 구하시오.
{
	int arr[5][5] = { 0 };
	int i , j, rnum;

	srand((unsigned)time(NULL));
	for (i = 0; i < 4; i++)
	{
		for (j = 0; j < 3; j++)
		{
			rnum = rand() % (50 - 21 + 1) + 21;
			arr[i][j] = rnum;
			arr[i][3] += rnum; //가로줄 합
			arr[4][j] += rnum; //세로줄 합
		}
	}
	//석차 구하기
	for (i = 0; i < 4; i++)
	{
		arr[i][4] = 1; //현재 1등
		for (j = 0; j < 5; j++) //모든 학생들과 비교...
			if (arr[i][3] < arr[j][3]) arr[i][4]++;
	}
		printf("============================================\n");
		printf("번호\t국어\t영어\t수학\t총점\t석차\n");
		printf("============================================\n");
	
	for (i = 0; i < 5; i++)
	{
		if(i < 4) printf("%3d\t", i + 1);
		else
		{
			printf("--------------------------------------------\n");
			printf("과목합\t");		 
		}
		for (j = 0; j < 5; j++)
		{
			printf("%3d\t", arr[i][j]);
		}
		printf("\n");
	}
	printf("--------------------------------------------\n");


}