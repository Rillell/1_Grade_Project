#include<stdio.h>
#include<stdlib.h>
#include<time.h>
void main()
//�Ʒ��� ���� �迭�� ����� 21 ~ 50������ ������ ä���� ���� �հ� ���� ���� ���Ͻÿ�.
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
			arr[i][3] += rnum; //������ ��
			arr[4][j] += rnum; //������ ��
		}
	}
	//���� ���ϱ�
	for (i = 0; i < 4; i++)
	{
		arr[i][4] = 1; //���� 1��
		for (j = 0; j < 5; j++) //��� �л���� ��...
			if (arr[i][3] < arr[j][3]) arr[i][4]++;
	}
		printf("============================================\n");
		printf("��ȣ\t����\t����\t����\t����\t����\n");
		printf("============================================\n");
	
	for (i = 0; i < 5; i++)
	{
		if(i < 4) printf("%3d\t", i + 1);
		else
		{
			printf("--------------------------------------------\n");
			printf("������\t");		 
		}
		for (j = 0; j < 5; j++)
		{
			printf("%3d\t", arr[i][j]);
		}
		printf("\n");
	}
	printf("--------------------------------------------\n");


}