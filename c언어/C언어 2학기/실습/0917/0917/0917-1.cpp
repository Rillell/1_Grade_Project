//�迭: �������� �޸� ����, ������ ������ Ÿ��

//����7���� ���� �ִ� �迭(arr)�� ����� 21~77������ ������ ä��� ����Ͻÿ�
/*#include<stdio.h>
#include<stdlib.h>
#include<time.h>
void main()
{
	int arr[7] = { 0 };
	int i, rnum;
	
	srand((unsigned)time(NULL));
	
	for (i = 0; i < 7; i++)
	{
		rnum = rand() % (77-21+1) + 21;
		arr[i] = rnum;
	}
	for (i = 0; i < 7; i++)
		printf("%5d", arr[i]);
	printf("\n\n");
}*/





//����7���� ���� �ִ� �迭(arr)�� ����� 21~77������ ������ '�ߺ�����' ä��� ����Ͻÿ�
#include<stdio.h>
#include<stdlib.h>
#include<time.h>
void main()
{
	int arr[7] = { 0 };
	int i,j, rnum, tmp;

	srand((unsigned)time(NULL));
	for (i = 0; i < 7; i++)
	{
		rnum = rand() % (77 - 21 + 1) + 21;
		//�ߺ� �����ϴ� �ڵ�
		for (j = 0; arr[j] > 0; j++)
			if (rnum == arr[j]) break;
		if(arr[j]==0)  arr[i] = rnum;
		else           i--;
	}
	printf("���� :");
	for (i = 0; i < 7; i++)
		printf("%5d", arr[i]);
	printf("\n\n");

	//���� ������� �����ϴ� �ڵ�(��Ʈ)
	for (i = 0; i < 6; i++)
	{
		for (j = i + 1; j < 7; j++)
		{
			if (arr[i] > arr[j])
			{
				tmp = arr[i];
				arr[i] = arr[j];
				arr[j] = tmp;
			}
		}
	}
	printf("��Ʈ :");
	for (i = 0; i < 7; i++)
		printf("%5d", arr[i]);
	printf("\n\n");
}